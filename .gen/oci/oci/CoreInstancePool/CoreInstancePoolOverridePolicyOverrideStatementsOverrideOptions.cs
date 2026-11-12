using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions")]
    public class CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions : oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#name CoreInstancePool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override CoreInstancePool#override}
        /// </remarks>
        [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride\"}")]
        public oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride Override
        {
            get;
            set;
        }
    }
}
