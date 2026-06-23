using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesTcg), fullyQualifiedName: "libvirt.domain.DomainFeaturesTcg")]
    public interface IDomainFeaturesTcg
    {
        /// <summary>Sets the size of the TCG translation block cache, with the numeric value paired with tb_cache_unit (for example 128 with unit "MiB").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tb_cache Domain#tb_cache}
        /// </remarks>
        [JsiiProperty(name: "tbCache", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TbCache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the unit used for the TCG translation block cache size, paired with tcg.tb_cache (for example "KiB", "MiB", or "GiB"); the exact unit string is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tb_cache_unit Domain#tb_cache_unit}
        /// </remarks>
        [JsiiProperty(name: "tbCacheUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TbCacheUnit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesTcg), fullyQualifiedName: "libvirt.domain.DomainFeaturesTcg")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesTcg
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the size of the TCG translation block cache, with the numeric value paired with tb_cache_unit (for example 128 with unit "MiB").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tb_cache Domain#tb_cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tbCache", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TbCache
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the unit used for the TCG translation block cache size, paired with tcg.tb_cache (for example "KiB", "MiB", or "GiB"); the exact unit string is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tb_cache_unit Domain#tb_cache_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tbCacheUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TbCacheUnit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
