﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace RulesEngine.Models
{
    [Obsolete("WorkflowRules class is deprecated. Use Workflow class instead.")]
    [ExcludeFromCodeCoverage]
    public class WorkflowRules : Workflow {
    }

    /// <summary>
    /// Workflow rules class for deserialization  the json config file
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Workflow
    {
        /// <summary>
        /// Reserved for Database / Entity Framework implementations
        /// </summary>
        [JsonIgnore]
        public int? Id { get; set; }
        /// <summary>
        /// Gets the workflow name.
        /// </summary>
        public virtual string WorkflowName { get; set; }

        /// <summary>Gets or sets the workflow rules to inject.</summary>
        /// <value>The workflow rules to inject.</value>
        [Obsolete("WorkflowRulesToInject is deprecated. Use WorkflowsToInject instead.")]
        public IEnumerable<string> WorkflowRulesToInject {
          set { WorkflowsToInject = value; }
        }
        public IEnumerable<string> WorkflowsToInject { get; set; }

        public RuleExpressionType RuleExpressionType { get; set; } = RuleExpressionType.LambdaExpression;

        /// <summary>
        /// Gets or Sets the global params which will be applicable to all rules
        /// </summary>
        public virtual IEnumerable<ScopedParam> GlobalParams { get; set; }

        /// <summary>
        /// list of rules.
        /// </summary>
        public virtual IEnumerable<Rule> Rules { get; set; }
        [JsonIgnore]
        public int Seq { get; set; }
    }
}
