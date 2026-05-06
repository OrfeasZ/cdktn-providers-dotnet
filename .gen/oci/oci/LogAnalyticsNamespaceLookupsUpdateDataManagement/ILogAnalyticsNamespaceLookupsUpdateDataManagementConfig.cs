using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookupsUpdateDataManagement
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceLookupsUpdateDataManagementConfig), fullyQualifiedName: "oci.logAnalyticsNamespaceLookupsUpdateDataManagement.LogAnalyticsNamespaceLookupsUpdateDataManagementConfig")]
    public interface ILogAnalyticsNamespaceLookupsUpdateDataManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#lookup_name LogAnalyticsNamespaceLookupsUpdateDataManagement#lookup_name}.</summary>
        [JsiiProperty(name: "lookupName", typeJson: "{\"primitive\":\"string\"}")]
        string LookupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#namespace LogAnalyticsNamespaceLookupsUpdateDataManagement#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#update_lookup_file LogAnalyticsNamespaceLookupsUpdateDataManagement#update_lookup_file}.</summary>
        [JsiiProperty(name: "updateLookupFile", typeJson: "{\"primitive\":\"string\"}")]
        string UpdateLookupFile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#char_encoding LogAnalyticsNamespaceLookupsUpdateDataManagement#char_encoding}.</summary>
        [JsiiProperty(name: "charEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CharEncoding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#expect LogAnalyticsNamespaceLookupsUpdateDataManagement#expect}.</summary>
        [JsiiProperty(name: "expect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#id LogAnalyticsNamespaceLookupsUpdateDataManagement#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#is_force LogAnalyticsNamespaceLookupsUpdateDataManagement#is_force}.</summary>
        [JsiiProperty(name: "isForce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsForce
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#timeouts LogAnalyticsNamespaceLookupsUpdateDataManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceLookupsUpdateDataManagement.LogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LogAnalyticsNamespaceLookupsUpdateDataManagement.ILogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceLookupsUpdateDataManagementConfig), fullyQualifiedName: "oci.logAnalyticsNamespaceLookupsUpdateDataManagement.LogAnalyticsNamespaceLookupsUpdateDataManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceLookupsUpdateDataManagement.ILogAnalyticsNamespaceLookupsUpdateDataManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#lookup_name LogAnalyticsNamespaceLookupsUpdateDataManagement#lookup_name}.</summary>
            [JsiiProperty(name: "lookupName", typeJson: "{\"primitive\":\"string\"}")]
            public string LookupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#namespace LogAnalyticsNamespaceLookupsUpdateDataManagement#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#update_lookup_file LogAnalyticsNamespaceLookupsUpdateDataManagement#update_lookup_file}.</summary>
            [JsiiProperty(name: "updateLookupFile", typeJson: "{\"primitive\":\"string\"}")]
            public string UpdateLookupFile
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#char_encoding LogAnalyticsNamespaceLookupsUpdateDataManagement#char_encoding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "charEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CharEncoding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#expect LogAnalyticsNamespaceLookupsUpdateDataManagement#expect}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expect
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#id LogAnalyticsNamespaceLookupsUpdateDataManagement#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#is_force LogAnalyticsNamespaceLookupsUpdateDataManagement#is_force}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isForce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsForce
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#timeouts LogAnalyticsNamespaceLookupsUpdateDataManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceLookupsUpdateDataManagement.LogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts\"}", isOptional: true)]
            public oci.LogAnalyticsNamespaceLookupsUpdateDataManagement.ILogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.LogAnalyticsNamespaceLookupsUpdateDataManagement.ILogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts?>();
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
