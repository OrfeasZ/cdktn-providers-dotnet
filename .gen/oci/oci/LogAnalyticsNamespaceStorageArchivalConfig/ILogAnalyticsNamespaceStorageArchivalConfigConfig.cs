using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceStorageArchivalConfig
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceStorageArchivalConfigConfig), fullyQualifiedName: "oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigConfig")]
    public interface ILogAnalyticsNamespaceStorageArchivalConfigConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>archiving_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#archiving_configuration LogAnalyticsNamespaceStorageArchivalConfig#archiving_configuration}
        /// </remarks>
        [JsiiProperty(name: "archivingConfiguration", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration\"}")]
        oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration ArchivingConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#namespace LogAnalyticsNamespaceStorageArchivalConfig#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#id LogAnalyticsNamespaceStorageArchivalConfig#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#timeouts LogAnalyticsNamespaceStorageArchivalConfig#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceStorageArchivalConfigConfig), fullyQualifiedName: "oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigConfig")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>archiving_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#archiving_configuration LogAnalyticsNamespaceStorageArchivalConfig#archiving_configuration}
            /// </remarks>
            [JsiiProperty(name: "archivingConfiguration", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration\"}")]
            public oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration ArchivingConfiguration
            {
                get => GetInstanceProperty<oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#namespace LogAnalyticsNamespaceStorageArchivalConfig#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#id LogAnalyticsNamespaceStorageArchivalConfig#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#timeouts LogAnalyticsNamespaceStorageArchivalConfig#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigTimeouts\"}", isOptional: true)]
            public oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigTimeouts?>();
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
