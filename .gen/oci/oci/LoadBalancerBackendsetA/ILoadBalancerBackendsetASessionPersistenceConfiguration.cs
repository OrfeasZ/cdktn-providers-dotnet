using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendsetA
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerBackendsetASessionPersistenceConfiguration), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfiguration")]
    public interface ILoadBalancerBackendsetASessionPersistenceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#cookie_name LoadBalancerBackendsetA#cookie_name}.</summary>
        [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}")]
        string CookieName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#disable_fallback LoadBalancerBackendsetA#disable_fallback}.</summary>
        [JsiiProperty(name: "disableFallback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableFallback
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerBackendsetASessionPersistenceConfiguration), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASessionPersistenceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#cookie_name LoadBalancerBackendsetA#cookie_name}.</summary>
            [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}")]
            public string CookieName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#disable_fallback LoadBalancerBackendsetA#disable_fallback}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableFallback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableFallback
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
