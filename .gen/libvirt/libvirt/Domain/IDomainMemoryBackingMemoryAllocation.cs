using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainMemoryBackingMemoryAllocation), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemoryAllocation")]
    public interface IDomainMemoryBackingMemoryAllocation
    {
        /// <summary>Sets the allocation mode for backing memory;</summary>
        /// <remarks>
        /// the value is user-provided and must be one of the modes supported by libvirt (for example, immediate vs. on‑demand allocation depending on hypervisor support).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the number of threads to use when performing the chosen memory allocation mode;</summary>
        /// <remarks>
        /// the value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#threads Domain#threads}
        /// </remarks>
        [JsiiProperty(name: "threads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Threads
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainMemoryBackingMemoryAllocation), fullyQualifiedName: "libvirt.domain.DomainMemoryBackingMemoryAllocation")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainMemoryBackingMemoryAllocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the allocation mode for backing memory;</summary>
            /// <remarks>
            /// the value is user-provided and must be one of the modes supported by libvirt (for example, immediate vs. on‑demand allocation depending on hypervisor support).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the number of threads to use when performing the chosen memory allocation mode;</summary>
            /// <remarks>
            /// the value is a user-provided positive integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#threads Domain#threads}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Threads
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
