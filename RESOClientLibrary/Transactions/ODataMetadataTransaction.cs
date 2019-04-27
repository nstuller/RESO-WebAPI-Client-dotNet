﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESOClientLibrary.Transactions
{
    public class ODataMetadataTransaction : ODataTransaction
    {
        public ODataMetadataTransaction(RESOClientSettings clientsettings) : base(clientsettings) { }
        public bool ExecuteEvent(RESOClient app)
        {
            try
            {
                responsedata = app.GetData(clientsettings.GetSetting(settings.webapi_uri).TrimEnd('/') + "/$metadata");
                app.LogData("Response Data");
                app.LogData("METADATA", responsedata);
                if (responsedata.IndexOf("\"error\":{") >= 0)
                {
                    app.LogData("ERROR", responsedata);
                    return false;
                }

            }
            catch (Exception ex)
            {
                app.LogData("ERROR", ex.Message);
                return false;
            }
            return true;
        }
    }

}
