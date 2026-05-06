using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolLoadBalancers")]
    public class CoreInstancePoolLoadBalancers : oci.CoreInstancePool.ICoreInstancePoolLoadBalancers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#backend_set_name CoreInstancePool#backend_set_name}.</summary>
        [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
        public string BackendSetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#load_balancer_id CoreInstancePool#load_balancer_id}.</summary>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public string LoadBalancerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#port CoreInstancePool#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#vnic_selection CoreInstancePool#vnic_selection}.</summary>
        [JsiiProperty(name: "vnicSelection", typeJson: "{\"primitive\":\"string\"}")]
        public string VnicSelection
        {
            get;
            set;
        }
    }
}
