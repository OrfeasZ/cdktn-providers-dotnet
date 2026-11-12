using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions")]
    public interface ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#name CoreInstancePool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override CoreInstancePool#override}
        /// </remarks>
        [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride\"}")]
        oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride Override
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#name CoreInstancePool#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override CoreInstancePool#override}
            /// </remarks>
            [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride\"}")]
            public oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride Override
            {
                get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride>()!;
            }
        }
    }
}
