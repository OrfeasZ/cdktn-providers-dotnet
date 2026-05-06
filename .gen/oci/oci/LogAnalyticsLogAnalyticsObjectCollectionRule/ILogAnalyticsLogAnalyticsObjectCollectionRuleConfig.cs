using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsObjectCollectionRule
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsLogAnalyticsObjectCollectionRuleConfig), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleConfig")]
    public interface ILogAnalyticsLogAnalyticsObjectCollectionRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#compartment_id LogAnalyticsLogAnalyticsObjectCollectionRule#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_group_id LogAnalyticsLogAnalyticsObjectCollectionRule#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#name LogAnalyticsLogAnalyticsObjectCollectionRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#namespace LogAnalyticsLogAnalyticsObjectCollectionRule#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#os_bucket_name LogAnalyticsLogAnalyticsObjectCollectionRule#os_bucket_name}.</summary>
        [JsiiProperty(name: "osBucketName", typeJson: "{\"primitive\":\"string\"}")]
        string OsBucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#os_namespace LogAnalyticsLogAnalyticsObjectCollectionRule#os_namespace}.</summary>
        [JsiiProperty(name: "osNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string OsNamespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#char_encoding LogAnalyticsLogAnalyticsObjectCollectionRule#char_encoding}.</summary>
        [JsiiProperty(name: "charEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CharEncoding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#collection_type LogAnalyticsLogAnalyticsObjectCollectionRule#collection_type}.</summary>
        [JsiiProperty(name: "collectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CollectionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#defined_tags LogAnalyticsLogAnalyticsObjectCollectionRule#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#description LogAnalyticsLogAnalyticsObjectCollectionRule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#entity_id LogAnalyticsLogAnalyticsObjectCollectionRule#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EntityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#freeform_tags LogAnalyticsLogAnalyticsObjectCollectionRule#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#id LogAnalyticsLogAnalyticsObjectCollectionRule#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#is_enabled LogAnalyticsLogAnalyticsObjectCollectionRule#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#is_force_historic_collection LogAnalyticsLogAnalyticsObjectCollectionRule#is_force_historic_collection}.</summary>
        [JsiiProperty(name: "isForceHistoricCollection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsForceHistoricCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_set LogAnalyticsLogAnalyticsObjectCollectionRule#log_set}.</summary>
        [JsiiProperty(name: "logSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_set_ext_regex LogAnalyticsLogAnalyticsObjectCollectionRule#log_set_ext_regex}.</summary>
        [JsiiProperty(name: "logSetExtRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogSetExtRegex
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_set_key LogAnalyticsLogAnalyticsObjectCollectionRule#log_set_key}.</summary>
        [JsiiProperty(name: "logSetKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogSetKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_source_name LogAnalyticsLogAnalyticsObjectCollectionRule#log_source_name}.</summary>
        [JsiiProperty(name: "logSourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogSourceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_type LogAnalyticsLogAnalyticsObjectCollectionRule#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#object_name_filters LogAnalyticsLogAnalyticsObjectCollectionRule#object_name_filters}.</summary>
        [JsiiProperty(name: "objectNameFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ObjectNameFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#overrides LogAnalyticsLogAnalyticsObjectCollectionRule#overrides}
        /// </remarks>
        [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Overrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#poll_since LogAnalyticsLogAnalyticsObjectCollectionRule#poll_since}.</summary>
        [JsiiProperty(name: "pollSince", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PollSince
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#poll_till LogAnalyticsLogAnalyticsObjectCollectionRule#poll_till}.</summary>
        [JsiiProperty(name: "pollTill", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PollTill
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#stream_cursor_time LogAnalyticsLogAnalyticsObjectCollectionRule#stream_cursor_time}.</summary>
        [JsiiProperty(name: "streamCursorTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamCursorTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#stream_cursor_type LogAnalyticsLogAnalyticsObjectCollectionRule#stream_cursor_type}.</summary>
        [JsiiProperty(name: "streamCursorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamCursorType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#stream_id LogAnalyticsLogAnalyticsObjectCollectionRule#stream_id}.</summary>
        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#timeouts LogAnalyticsLogAnalyticsObjectCollectionRule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LogAnalyticsLogAnalyticsObjectCollectionRule.ILogAnalyticsLogAnalyticsObjectCollectionRuleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#timezone LogAnalyticsLogAnalyticsObjectCollectionRule#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timezone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsLogAnalyticsObjectCollectionRuleConfig), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleConfig")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsLogAnalyticsObjectCollectionRule.ILogAnalyticsLogAnalyticsObjectCollectionRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#compartment_id LogAnalyticsLogAnalyticsObjectCollectionRule#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_group_id LogAnalyticsLogAnalyticsObjectCollectionRule#log_group_id}.</summary>
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#name LogAnalyticsLogAnalyticsObjectCollectionRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#namespace LogAnalyticsLogAnalyticsObjectCollectionRule#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#os_bucket_name LogAnalyticsLogAnalyticsObjectCollectionRule#os_bucket_name}.</summary>
            [JsiiProperty(name: "osBucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string OsBucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#os_namespace LogAnalyticsLogAnalyticsObjectCollectionRule#os_namespace}.</summary>
            [JsiiProperty(name: "osNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string OsNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#char_encoding LogAnalyticsLogAnalyticsObjectCollectionRule#char_encoding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "charEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CharEncoding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#collection_type LogAnalyticsLogAnalyticsObjectCollectionRule#collection_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "collectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CollectionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#defined_tags LogAnalyticsLogAnalyticsObjectCollectionRule#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#description LogAnalyticsLogAnalyticsObjectCollectionRule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#entity_id LogAnalyticsLogAnalyticsObjectCollectionRule#entity_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EntityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#freeform_tags LogAnalyticsLogAnalyticsObjectCollectionRule#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#id LogAnalyticsLogAnalyticsObjectCollectionRule#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#is_enabled LogAnalyticsLogAnalyticsObjectCollectionRule#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#is_force_historic_collection LogAnalyticsLogAnalyticsObjectCollectionRule#is_force_historic_collection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isForceHistoricCollection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsForceHistoricCollection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_set LogAnalyticsLogAnalyticsObjectCollectionRule#log_set}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogSet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_set_ext_regex LogAnalyticsLogAnalyticsObjectCollectionRule#log_set_ext_regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logSetExtRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogSetExtRegex
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_set_key LogAnalyticsLogAnalyticsObjectCollectionRule#log_set_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logSetKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogSetKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_source_name LogAnalyticsLogAnalyticsObjectCollectionRule#log_source_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logSourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogSourceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#log_type LogAnalyticsLogAnalyticsObjectCollectionRule#log_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#object_name_filters LogAnalyticsLogAnalyticsObjectCollectionRule#object_name_filters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectNameFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ObjectNameFilters
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#overrides LogAnalyticsLogAnalyticsObjectCollectionRule#overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Overrides
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#poll_since LogAnalyticsLogAnalyticsObjectCollectionRule#poll_since}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pollSince", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PollSince
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#poll_till LogAnalyticsLogAnalyticsObjectCollectionRule#poll_till}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pollTill", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PollTill
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#stream_cursor_time LogAnalyticsLogAnalyticsObjectCollectionRule#stream_cursor_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamCursorTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamCursorTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#stream_cursor_type LogAnalyticsLogAnalyticsObjectCollectionRule#stream_cursor_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamCursorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamCursorType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#stream_id LogAnalyticsLogAnalyticsObjectCollectionRule#stream_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#timeouts LogAnalyticsLogAnalyticsObjectCollectionRule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleTimeouts\"}", isOptional: true)]
            public oci.LogAnalyticsLogAnalyticsObjectCollectionRule.ILogAnalyticsLogAnalyticsObjectCollectionRuleTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.LogAnalyticsLogAnalyticsObjectCollectionRule.ILogAnalyticsLogAnalyticsObjectCollectionRuleTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#timezone LogAnalyticsLogAnalyticsObjectCollectionRule#timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timezone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
