using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OdaOdaPrivateEndpointScanProxy
{
    [JsiiInterface(nativeType: typeof(IOdaOdaPrivateEndpointScanProxyConfig), fullyQualifiedName: "oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyConfig")]
    public interface IOdaOdaPrivateEndpointScanProxyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#oda_private_endpoint_id OdaOdaPrivateEndpointScanProxy#oda_private_endpoint_id}.</summary>
        [JsiiProperty(name: "odaPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string OdaPrivateEndpointId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#protocol OdaOdaPrivateEndpointScanProxy#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>scan_listener_infos block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_infos OdaOdaPrivateEndpointScanProxy#scan_listener_infos}
        /// </remarks>
        [JsiiProperty(name: "scanListenerInfos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyScanListenerInfos\"},\"kind\":\"array\"}}]}}")]
        object ScanListenerInfos
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_type OdaOdaPrivateEndpointScanProxy#scan_listener_type}.</summary>
        [JsiiProperty(name: "scanListenerType", typeJson: "{\"primitive\":\"string\"}")]
        string ScanListenerType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#id OdaOdaPrivateEndpointScanProxy#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#timeouts OdaOdaPrivateEndpointScanProxy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OdaOdaPrivateEndpointScanProxy.IOdaOdaPrivateEndpointScanProxyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdaOdaPrivateEndpointScanProxyConfig), fullyQualifiedName: "oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OdaOdaPrivateEndpointScanProxy.IOdaOdaPrivateEndpointScanProxyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#oda_private_endpoint_id OdaOdaPrivateEndpointScanProxy#oda_private_endpoint_id}.</summary>
            [JsiiProperty(name: "odaPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string OdaPrivateEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#protocol OdaOdaPrivateEndpointScanProxy#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>scan_listener_infos block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_infos OdaOdaPrivateEndpointScanProxy#scan_listener_infos}
            /// </remarks>
            [JsiiProperty(name: "scanListenerInfos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyScanListenerInfos\"},\"kind\":\"array\"}}]}}")]
            public object ScanListenerInfos
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_type OdaOdaPrivateEndpointScanProxy#scan_listener_type}.</summary>
            [JsiiProperty(name: "scanListenerType", typeJson: "{\"primitive\":\"string\"}")]
            public string ScanListenerType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#id OdaOdaPrivateEndpointScanProxy#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#timeouts OdaOdaPrivateEndpointScanProxy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyTimeouts\"}", isOptional: true)]
            public oci.OdaOdaPrivateEndpointScanProxy.IOdaOdaPrivateEndpointScanProxyTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OdaOdaPrivateEndpointScanProxy.IOdaOdaPrivateEndpointScanProxyTimeouts?>();
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
