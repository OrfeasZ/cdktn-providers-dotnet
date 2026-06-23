using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainIdMapUiDs), fullyQualifiedName: "libvirt.domain.DomainIdMapUiDs")]
    public interface IDomainIdMapUiDs
    {
        /// <summary>Sets the number of consecutive GIDs in this mapping range; must be a positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#count Domain#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        /// <summary>Sets the starting guest GID for this mapping range; must be a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#start Domain#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        double Start
        {
            get;
        }

        /// <summary>Sets the starting host GID that the guest GIDs in this range are mapped to;</summary>
        /// <remarks>
        /// must be a non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
        double Target
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainIdMapUiDs), fullyQualifiedName: "libvirt.domain.DomainIdMapUiDs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainIdMapUiDs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the number of consecutive GIDs in this mapping range; must be a positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#count Domain#count}
            /// </remarks>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the starting guest GID for this mapping range; must be a non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#start Domain#start}
            /// </remarks>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
            public double Start
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the starting host GID that the guest GIDs in this range are mapped to;</summary>
            /// <remarks>
            /// must be a non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
            public double Target
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
