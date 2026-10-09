using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    [JsiiInterface(nativeType: typeof(IMicrovmSize), fullyQualifiedName: "digitalocean.microvm.MicrovmSize")]
    public interface IMicrovmSize
    {
        /// <summary>Number of vCPUs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#cpu Microvm#cpu}
        /// </remarks>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        double Cpu
        {
            get;
        }

        /// <summary>Memory in MiB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#memory Microvm#memory}
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        double Memory
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMicrovmSize), fullyQualifiedName: "digitalocean.microvm.MicrovmSize")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Microvm.IMicrovmSize
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of vCPUs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#cpu Microvm#cpu}
            /// </remarks>
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
            public double Cpu
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Memory in MiB.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#memory Microvm#memory}
            /// </remarks>
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
            public double Memory
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
