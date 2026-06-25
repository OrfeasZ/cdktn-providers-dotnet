using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTermination")]
    public interface ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/core_instance_pool#is_enabled CoreInstancePool#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        /// <summary>on_timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/core_instance_pool#on_timeout CoreInstancePool#on_timeout}
        /// </remarks>
        [JsiiProperty(name: "onTimeout", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout\"}")]
        oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout OnTimeout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/core_instance_pool#timeout CoreInstancePool#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        double Timeout
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTermination")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/core_instance_pool#is_enabled CoreInstancePool#is_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>on_timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/core_instance_pool#on_timeout CoreInstancePool#on_timeout}
            /// </remarks>
            [JsiiProperty(name: "onTimeout", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout\"}")]
            public oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout OnTimeout
            {
                get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/core_instance_pool#timeout CoreInstancePool#timeout}.</summary>
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
            public double Timeout
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
