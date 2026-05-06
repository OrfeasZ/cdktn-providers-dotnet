using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolLoadBalancers), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLoadBalancers")]
    public interface ICoreInstancePoolLoadBalancers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#backend_set_name CoreInstancePool#backend_set_name}.</summary>
        [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
        string BackendSetName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#load_balancer_id CoreInstancePool#load_balancer_id}.</summary>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#port CoreInstancePool#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#vnic_selection CoreInstancePool#vnic_selection}.</summary>
        [JsiiProperty(name: "vnicSelection", typeJson: "{\"primitive\":\"string\"}")]
        string VnicSelection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolLoadBalancers), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLoadBalancers")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolLoadBalancers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#backend_set_name CoreInstancePool#backend_set_name}.</summary>
            [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendSetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#load_balancer_id CoreInstancePool#load_balancer_id}.</summary>
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#port CoreInstancePool#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#vnic_selection CoreInstancePool#vnic_selection}.</summary>
            [JsiiProperty(name: "vnicSelection", typeJson: "{\"primitive\":\"string\"}")]
            public string VnicSelection
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
