using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsFirmwareInfoFeatures), fullyQualifiedName: "libvirt.domain.DomainOsFirmwareInfoFeatures")]
    public interface IDomainOsFirmwareInfoFeatures
    {
        /// <summary>Sets whether the given firmware feature entry is enabled, typically as a boolean-like flag (for example "yes"/"no" or "on"/"off") as required by the firmware.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enabled Domain#enabled}
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

        /// <summary>Specifies the name/identifier of the firmware feature to control (value is user-provided and must match a feature understood by the chosen firmware).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsFirmwareInfoFeatures), fullyQualifiedName: "libvirt.domain.DomainOsFirmwareInfoFeatures")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsFirmwareInfoFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets whether the given firmware feature entry is enabled, typically as a boolean-like flag (for example "yes"/"no" or "on"/"off") as required by the firmware.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enabled Domain#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Enabled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the name/identifier of the firmware feature to control (value is user-provided and must match a feature understood by the chosen firmware).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
