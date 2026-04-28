using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.LoadBalancerService
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerServiceConfig), fullyQualifiedName: "hcloud.loadBalancerService.LoadBalancerServiceConfig")]
    public interface ILoadBalancerServiceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#load_balancer_id LoadBalancerService#load_balancer_id}.</summary>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#protocol LoadBalancerService#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#destination_port LoadBalancerService#destination_port}.</summary>
        [JsiiProperty(name: "destinationPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DestinationPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#health_check LoadBalancerService#health_check}
        /// </remarks>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHealthCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        hcloud.LoadBalancerService.ILoadBalancerServiceHealthCheck? HealthCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#http LoadBalancerService#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        hcloud.LoadBalancerService.ILoadBalancerServiceHttp? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#id LoadBalancerService#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#listen_port LoadBalancerService#listen_port}.</summary>
        [JsiiProperty(name: "listenPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ListenPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#proxyprotocol LoadBalancerService#proxyprotocol}.</summary>
        [JsiiProperty(name: "proxyprotocol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Proxyprotocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerServiceConfig), fullyQualifiedName: "hcloud.loadBalancerService.LoadBalancerServiceConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.LoadBalancerService.ILoadBalancerServiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#load_balancer_id LoadBalancerService#load_balancer_id}.</summary>
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#protocol LoadBalancerService#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#destination_port LoadBalancerService#destination_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DestinationPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>health_check block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#health_check LoadBalancerService#health_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHealthCheck\"}", isOptional: true)]
            public hcloud.LoadBalancerService.ILoadBalancerServiceHealthCheck? HealthCheck
            {
                get => GetInstanceProperty<hcloud.LoadBalancerService.ILoadBalancerServiceHealthCheck?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#http LoadBalancerService#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHttp\"}", isOptional: true)]
            public hcloud.LoadBalancerService.ILoadBalancerServiceHttp? Http
            {
                get => GetInstanceProperty<hcloud.LoadBalancerService.ILoadBalancerServiceHttp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#id LoadBalancerService#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#listen_port LoadBalancerService#listen_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listenPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ListenPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_service#proxyprotocol LoadBalancerService#proxyprotocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyprotocol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Proxyprotocol
            {
                get => GetInstanceProperty<object?>();
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
