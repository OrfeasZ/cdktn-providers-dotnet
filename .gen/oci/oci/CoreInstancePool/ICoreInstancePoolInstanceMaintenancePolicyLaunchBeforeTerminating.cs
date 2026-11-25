using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating")]
    public interface ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#is_full_refresh CoreInstancePool#is_full_refresh}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isFullRefresh", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsFullRefresh
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#max_healthy_percent CoreInstancePool#max_healthy_percent}.</summary>
        [JsiiProperty(name: "maxHealthyPercent", typeJson: "{\"primitive\":\"number\"}")]
        double MaxHealthyPercent
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#is_full_refresh CoreInstancePool#is_full_refresh}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isFullRefresh", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsFullRefresh
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#max_healthy_percent CoreInstancePool#max_healthy_percent}.</summary>
            [JsiiProperty(name: "maxHealthyPercent", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxHealthyPercent
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
