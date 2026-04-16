using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesBackendStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesBackendStageLbBackendConfigLbConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfig")]
    public interface IEdgeServicesBackendStageLbBackendConfigLbConfig
    {
        /// <summary>Fully Qualified Domain Name (in the format subdomain.example.com) to use in HTTP requests sent towards your Load Balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#domain_name EdgeServicesBackendStage#domain_name}
        /// </remarks>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the frontend linked to the Load Balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#frontend_id EdgeServicesBackendStage#frontend_id}
        /// </remarks>
        [JsiiProperty(name: "frontendId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FrontendId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines whether to forward websocket requests to the load balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#has_websocket EdgeServicesBackendStage#has_websocket}
        /// </remarks>
        [JsiiProperty(name: "hasWebsocket", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HasWebsocket
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the Load Balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#id EdgeServicesBackendStage#id}
        ///
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

        /// <summary>Defines whether the Load Balancer's frontend handles SSL connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#is_ssl EdgeServicesBackendStage#is_ssl}
        /// </remarks>
        [JsiiProperty(name: "isSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSsl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#zone EdgeServicesBackendStage#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesBackendStageLbBackendConfigLbConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Fully Qualified Domain Name (in the format subdomain.example.com) to use in HTTP requests sent towards your Load Balancer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#domain_name EdgeServicesBackendStage#domain_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the frontend linked to the Load Balancer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#frontend_id EdgeServicesBackendStage#frontend_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frontendId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FrontendId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines whether to forward websocket requests to the load balancer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#has_websocket EdgeServicesBackendStage#has_websocket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hasWebsocket", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HasWebsocket
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ID of the Load Balancer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#id EdgeServicesBackendStage#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines whether the Load Balancer's frontend handles SSL connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#is_ssl EdgeServicesBackendStage#is_ssl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSsl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#zone EdgeServicesBackendStage#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
