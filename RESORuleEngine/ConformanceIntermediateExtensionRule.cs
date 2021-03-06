﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace ODataValidator.RuleEngine
{
    public abstract class ConformanceIntermediateExtensionRule : ConformanceExtensionRule
    {
        /// <summary>
        /// Gets the conformance level type.
        /// </summary>
        public override ConformanceLevelType? LevelType
        {
            get
            {
                return ConformanceLevelType.Intermediate;
            }
        }
    }
}