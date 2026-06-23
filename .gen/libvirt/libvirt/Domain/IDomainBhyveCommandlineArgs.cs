using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainBhyveCommandlineArgs), fullyQualifiedName: "libvirt.domain.DomainBhyveCommandlineArgs")]
    public interface IDomainBhyveCommandlineArgs
    {
        /// <summary>Sets one additional argument token passed to the bhyve process.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvbhyve.html">https://libvirt.org/drvbhyve.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainBhyveCommandlineArgs), fullyQualifiedName: "libvirt.domain.DomainBhyveCommandlineArgs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainBhyveCommandlineArgs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets one additional argument token passed to the bhyve process.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/drvbhyve.html">https://libvirt.org/drvbhyve.html</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
