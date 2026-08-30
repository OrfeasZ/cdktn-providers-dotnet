using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesIommuAcpi), fullyQualifiedName: "libvirt.domain.DomainDevicesIommuAcpi")]
    public interface IDomainDevicesIommuAcpi
    {
        /// <summary>Sets the ACPI ERST record index used by this pstore device; the value is a user-provided non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#index Domain#index}
        /// </remarks>
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Index
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nodeset Domain#nodeset}.</summary>
        [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Nodeset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesIommuAcpi), fullyQualifiedName: "libvirt.domain.DomainDevicesIommuAcpi")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesIommuAcpi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the ACPI ERST record index used by this pstore device; the value is a user-provided non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#index Domain#index}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Index
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nodeset Domain#nodeset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Nodeset
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
