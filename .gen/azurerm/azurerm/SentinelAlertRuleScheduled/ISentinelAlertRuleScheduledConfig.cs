using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleScheduled
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleScheduledConfig), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledConfig")]
    public interface ISentinelAlertRuleScheduledConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#display_name SentinelAlertRuleScheduled#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#log_analytics_workspace_id SentinelAlertRuleScheduled#log_analytics_workspace_id}.</summary>
        [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string LogAnalyticsWorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#name SentinelAlertRuleScheduled#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#query SentinelAlertRuleScheduled#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        string Query
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#severity SentinelAlertRuleScheduled#severity}.</summary>
        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        string Severity
        {
            get;
        }

        /// <summary>alert_details_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#alert_details_override SentinelAlertRuleScheduled#alert_details_override}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledAlertDetailsOverride" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "alertDetailsOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledAlertDetailsOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AlertDetailsOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#alert_rule_template_guid SentinelAlertRuleScheduled#alert_rule_template_guid}.</summary>
        [JsiiProperty(name: "alertRuleTemplateGuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlertRuleTemplateGuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#alert_rule_template_version SentinelAlertRuleScheduled#alert_rule_template_version}.</summary>
        [JsiiProperty(name: "alertRuleTemplateVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlertRuleTemplateVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#custom_details SentinelAlertRuleScheduled#custom_details}.</summary>
        [JsiiProperty(name: "customDetails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CustomDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#description SentinelAlertRuleScheduled#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#enabled SentinelAlertRuleScheduled#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>entity_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#entity_mapping SentinelAlertRuleScheduled#entity_mapping}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledEntityMapping" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "entityMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEntityMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EntityMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>event_grouping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#event_grouping SentinelAlertRuleScheduled#event_grouping}
        /// </remarks>
        [JsiiProperty(name: "eventGrouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEventGrouping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledEventGrouping? EventGrouping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#id SentinelAlertRuleScheduled#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>incident block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#incident SentinelAlertRuleScheduled#incident}
        /// </remarks>
        [JsiiProperty(name: "incident", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncident\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncident? Incident
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#query_frequency SentinelAlertRuleScheduled#query_frequency}.</summary>
        [JsiiProperty(name: "queryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#query_period SentinelAlertRuleScheduled#query_period}.</summary>
        [JsiiProperty(name: "queryPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>sentinel_entity_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#sentinel_entity_mapping SentinelAlertRuleScheduled#sentinel_entity_mapping}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledSentinelEntityMapping" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sentinelEntityMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledSentinelEntityMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SentinelEntityMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#suppression_duration SentinelAlertRuleScheduled#suppression_duration}.</summary>
        [JsiiProperty(name: "suppressionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SuppressionDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#suppression_enabled SentinelAlertRuleScheduled#suppression_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "suppressionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SuppressionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#tactics SentinelAlertRuleScheduled#tactics}.</summary>
        [JsiiProperty(name: "tactics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tactics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#techniques SentinelAlertRuleScheduled#techniques}.</summary>
        [JsiiProperty(name: "techniques", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Techniques
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#timeouts SentinelAlertRuleScheduled#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#trigger_operator SentinelAlertRuleScheduled#trigger_operator}.</summary>
        [JsiiProperty(name: "triggerOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TriggerOperator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#trigger_threshold SentinelAlertRuleScheduled#trigger_threshold}.</summary>
        [JsiiProperty(name: "triggerThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TriggerThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleScheduledConfig), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#display_name SentinelAlertRuleScheduled#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#log_analytics_workspace_id SentinelAlertRuleScheduled#log_analytics_workspace_id}.</summary>
            [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogAnalyticsWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#name SentinelAlertRuleScheduled#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#query SentinelAlertRuleScheduled#query}.</summary>
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
            public string Query
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#severity SentinelAlertRuleScheduled#severity}.</summary>
            [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
            public string Severity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>alert_details_override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#alert_details_override SentinelAlertRuleScheduled#alert_details_override}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledAlertDetailsOverride" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alertDetailsOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledAlertDetailsOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AlertDetailsOverride
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#alert_rule_template_guid SentinelAlertRuleScheduled#alert_rule_template_guid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alertRuleTemplateGuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlertRuleTemplateGuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#alert_rule_template_version SentinelAlertRuleScheduled#alert_rule_template_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alertRuleTemplateVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlertRuleTemplateVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#custom_details SentinelAlertRuleScheduled#custom_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customDetails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CustomDetails
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#description SentinelAlertRuleScheduled#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#enabled SentinelAlertRuleScheduled#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>entity_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#entity_mapping SentinelAlertRuleScheduled#entity_mapping}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledEntityMapping" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entityMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEntityMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EntityMapping
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>event_grouping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#event_grouping SentinelAlertRuleScheduled#event_grouping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventGrouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEventGrouping\"}", isOptional: true)]
            public azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledEventGrouping? EventGrouping
            {
                get => GetInstanceProperty<azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledEventGrouping?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#id SentinelAlertRuleScheduled#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>incident block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#incident SentinelAlertRuleScheduled#incident}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "incident", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncident\"}", isOptional: true)]
            public azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncident? Incident
            {
                get => GetInstanceProperty<azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncident?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#query_frequency SentinelAlertRuleScheduled#query_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#query_period SentinelAlertRuleScheduled#query_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryPeriod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>sentinel_entity_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#sentinel_entity_mapping SentinelAlertRuleScheduled#sentinel_entity_mapping}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledSentinelEntityMapping" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sentinelEntityMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledSentinelEntityMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SentinelEntityMapping
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#suppression_duration SentinelAlertRuleScheduled#suppression_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "suppressionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SuppressionDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#suppression_enabled SentinelAlertRuleScheduled#suppression_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suppressionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SuppressionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#tactics SentinelAlertRuleScheduled#tactics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tactics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tactics
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#techniques SentinelAlertRuleScheduled#techniques}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "techniques", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Techniques
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#timeouts SentinelAlertRuleScheduled#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledTimeouts\"}", isOptional: true)]
            public azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#trigger_operator SentinelAlertRuleScheduled#trigger_operator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggerOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TriggerOperator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_alert_rule_scheduled#trigger_threshold SentinelAlertRuleScheduled#trigger_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggerThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TriggerThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
