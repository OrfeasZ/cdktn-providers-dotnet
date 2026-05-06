using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalyzerTest
{
    [JsiiInterface(nativeType: typeof(IVnMonitoringPathAnalyzerTestConfig), fullyQualifiedName: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestConfig")]
    public interface IVnMonitoringPathAnalyzerTestConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#compartment_id VnMonitoringPathAnalyzerTest#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>destination_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#destination_endpoint VnMonitoringPathAnalyzerTest#destination_endpoint}
        /// </remarks>
        [JsiiProperty(name: "destinationEndpoint", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestDestinationEndpoint\"}")]
        oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestDestinationEndpoint DestinationEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#protocol VnMonitoringPathAnalyzerTest#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}")]
        double Protocol
        {
            get;
        }

        /// <summary>source_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#source_endpoint VnMonitoringPathAnalyzerTest#source_endpoint}
        /// </remarks>
        [JsiiProperty(name: "sourceEndpoint", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpoint\"}")]
        oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestSourceEndpoint SourceEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#defined_tags VnMonitoringPathAnalyzerTest#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#display_name VnMonitoringPathAnalyzerTest#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#freeform_tags VnMonitoringPathAnalyzerTest#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#id VnMonitoringPathAnalyzerTest#id}.</summary>
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

        /// <summary>protocol_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#protocol_parameters VnMonitoringPathAnalyzerTest#protocol_parameters}
        /// </remarks>
        [JsiiProperty(name: "protocolParameters", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestProtocolParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestProtocolParameters? ProtocolParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#query_options VnMonitoringPathAnalyzerTest#query_options}
        /// </remarks>
        [JsiiProperty(name: "queryOptions", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions? QueryOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#timeouts VnMonitoringPathAnalyzerTest#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVnMonitoringPathAnalyzerTestConfig), fullyQualifiedName: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestConfig")]
        internal sealed class _Proxy : DeputyBase, oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#compartment_id VnMonitoringPathAnalyzerTest#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destination_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#destination_endpoint VnMonitoringPathAnalyzerTest#destination_endpoint}
            /// </remarks>
            [JsiiProperty(name: "destinationEndpoint", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestDestinationEndpoint\"}")]
            public oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestDestinationEndpoint DestinationEndpoint
            {
                get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestDestinationEndpoint>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#protocol VnMonitoringPathAnalyzerTest#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}")]
            public double Protocol
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>source_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#source_endpoint VnMonitoringPathAnalyzerTest#source_endpoint}
            /// </remarks>
            [JsiiProperty(name: "sourceEndpoint", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpoint\"}")]
            public oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestSourceEndpoint SourceEndpoint
            {
                get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestSourceEndpoint>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#defined_tags VnMonitoringPathAnalyzerTest#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#display_name VnMonitoringPathAnalyzerTest#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#freeform_tags VnMonitoringPathAnalyzerTest#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#id VnMonitoringPathAnalyzerTest#id}.</summary>
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

            /// <summary>protocol_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#protocol_parameters VnMonitoringPathAnalyzerTest#protocol_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocolParameters", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestProtocolParameters\"}", isOptional: true)]
            public oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestProtocolParameters? ProtocolParameters
            {
                get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestProtocolParameters?>();
            }

            /// <summary>query_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#query_options VnMonitoringPathAnalyzerTest#query_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryOptions", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptions\"}", isOptional: true)]
            public oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions? QueryOptions
            {
                get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#timeouts VnMonitoringPathAnalyzerTest#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestTimeouts\"}", isOptional: true)]
            public oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestTimeouts?>();
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
