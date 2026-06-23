using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainSecLabel), fullyQualifiedName: "libvirt.domain.DomainSecLabel")]
    public interface IDomainSecLabel
    {
        /// <summary>Sets the base label template that libvirt may use as a starting point when generating dynamic security labels for the domain;</summary>
        /// <remarks>
        /// the value is user-provided (for example, "system_u:system_r:svirt_t:s0").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#base_label Domain#base_label}
        /// </remarks>
        [JsiiProperty(name: "baseLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the security label that should be applied to guest image files associated with this domain;</summary>
        /// <remarks>
        /// the value is user-provided and must be compatible with the selected security model.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#image_label Domain#image_label}
        /// </remarks>
        [JsiiProperty(name: "imageLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the domain’s own security label (for example SELinux or DAC label) when using static or explicit labeling;</summary>
        /// <remarks>
        /// the value is user-provided and must be valid for the chosen security driver.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#label Domain#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects which security driver/model to use for labeling this domain, typically "selinux" or "dac";</summary>
        /// <remarks>
        /// other values are driver-specific and must match a security driver enabled on the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether libvirt is allowed to change labels on associated resources at start time, using yes/no string values ("yes" to relabel resources automatically, "no" to leave existing labels unchanged).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#relabel Domain#relabel}
        /// </remarks>
        [JsiiProperty(name: "relabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Relabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the seclabel mode, typically "dynamic", "static", or "none", which determines whether libvirt auto-generates labels, uses explicitly provided labels, or disables security labeling for this domain.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainSecLabel), fullyQualifiedName: "libvirt.domain.DomainSecLabel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainSecLabel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the base label template that libvirt may use as a starting point when generating dynamic security labels for the domain;</summary>
            /// <remarks>
            /// the value is user-provided (for example, "system_u:system_r:svirt_t:s0").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#base_label Domain#base_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the security label that should be applied to guest image files associated with this domain;</summary>
            /// <remarks>
            /// the value is user-provided and must be compatible with the selected security model.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#image_label Domain#image_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the domain’s own security label (for example SELinux or DAC label) when using static or explicit labeling;</summary>
            /// <remarks>
            /// the value is user-provided and must be valid for the chosen security driver.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#label Domain#label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects which security driver/model to use for labeling this domain, typically "selinux" or "dac";</summary>
            /// <remarks>
            /// other values are driver-specific and must match a security driver enabled on the host.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Model
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether libvirt is allowed to change labels on associated resources at start time, using yes/no string values ("yes" to relabel resources automatically, "no" to leave existing labels unchanged).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#relabel Domain#relabel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Relabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the seclabel mode, typically "dynamic", "static", or "none", which determines whether libvirt auto-generates labels, uses explicitly provided labels, or disables security labeling for this domain.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
