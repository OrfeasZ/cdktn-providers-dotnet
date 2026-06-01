using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SPool
{
    [JsiiInterface(nativeType: typeof(IK8SPoolStartupTaints), fullyQualifiedName: "scaleway.k8SPool.K8SPoolStartupTaints")]
    public interface IK8SPoolStartupTaints
    {
        /// <summary>Effect of the taint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#effect K8SPool#effect}
        /// </remarks>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        string Effect
        {
            get;
        }

        /// <summary>Key of the taint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#key K8SPool#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Value of the taint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#value K8SPool#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IK8SPoolStartupTaints), fullyQualifiedName: "scaleway.k8SPool.K8SPoolStartupTaints")]
        internal sealed class _Proxy : DeputyBase, scaleway.K8SPool.IK8SPoolStartupTaints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Effect of the taint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#effect K8SPool#effect}
            /// </remarks>
            [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
            public string Effect
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Key of the taint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#key K8SPool#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Value of the taint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/k8s_pool#value K8SPool#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
