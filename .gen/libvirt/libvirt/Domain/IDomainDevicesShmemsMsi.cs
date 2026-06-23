using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesShmemsMsi), fullyQualifiedName: "libvirt.domain.DomainDevicesShmemsMsi")]
    public interface IDomainDevicesShmemsMsi
    {
        /// <summary>Toggles MSI support for the shared memory device;</summary>
        /// <remarks>
        /// accepts "on"/"off" (or "yes"/"no") as a string flag depending on driver support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables ioeventfd usage for MSI signaling; value is a string yes/no-style flag interpreted by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_event_fd Domain#io_event_fd}
        /// </remarks>
        [JsiiProperty(name: "ioEventFd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IoEventFd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of MSI vectors (interrupts) allocated for this shared memory device as a positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vectors Domain#vectors}
        /// </remarks>
        [JsiiProperty(name: "vectors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vectors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesShmemsMsi), fullyQualifiedName: "libvirt.domain.DomainDevicesShmemsMsi")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesShmemsMsi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Toggles MSI support for the shared memory device;</summary>
            /// <remarks>
            /// accepts "on"/"off" (or "yes"/"no") as a string flag depending on driver support.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Enabled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables ioeventfd usage for MSI signaling; value is a string yes/no-style flag interpreted by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_event_fd Domain#io_event_fd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioEventFd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IoEventFd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the number of MSI vectors (interrupts) allocated for this shared memory device as a positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vectors Domain#vectors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vectors
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
