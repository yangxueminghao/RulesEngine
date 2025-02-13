﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace RulesEngine.Models
{
    /// <summary>
    /// Rule class
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Rule
    {
        /// <summary>
        /// Reserved for Database / Entity Framework implementations
        /// </summary>
        [JsonIgnore]
        public int? Id { get; set; }
        /// <summary>
        /// Rule name for the Rule
        /// </summary>
        public string RuleName { get; set; }
        /// <summary>	
        /// Gets or sets the custom property or tags of the rule.	
        /// </summary>	
        /// <value>	
        /// The properties of the rule.	
        /// </value>	
        public Dictionary<string, object> Properties { get; set; }
        public string Operator { get; set; }
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets whether the rule is enabled.
        /// </summary>
        public bool Enabled { get; set; } = true;

        [JsonConverter(typeof(StringEnumConverter))]
        public RuleExpressionType RuleExpressionType { get; set; } = RuleExpressionType.LambdaExpression;
        public virtual IEnumerable<string> WorkflowsToInject { get; set; }
        public virtual IEnumerable<Rule> Rules { get; set; }
        public IEnumerable<ScopedParam> LocalParams { get; set; }
        public string Expression { get; set; }
        public RuleActions Actions { get; set; }
        public string SuccessEvent { get; set; }
        [JsonIgnore]
        public bool? IsSuccess { get; set; }
        [JsonIgnore]
        public string ExceptionMessage { get; set; }
        [JsonIgnore]
        public int Seq { get; set; }

    }
}
