using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorActivePcrBanks), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorActivePcrBanks")]
    public interface IDomainDevicesTpmsBackendEmulatorActivePcrBanks
    {
        /// <summary>Presence-only flag that enables a SHA‑1 PCR bank in the emulated TPM when set to true;</summary>
        /// <remarks>
        /// omitting or setting false leaves it disabled.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sha1 Domain#sha1}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sha1", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sha1
        {
            get
            {
                return null;
            }
        }

        /// <summary>Presence-only flag that enables a SHA‑256 PCR bank in the emulated TPM when set to true;</summary>
        /// <remarks>
        /// omitting or setting false leaves it disabled.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sha256 Domain#sha256}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sha256", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sha256
        {
            get
            {
                return null;
            }
        }

        /// <summary>Presence-only flag that enables a SHA‑384 PCR bank in the emulated TPM when set to true;</summary>
        /// <remarks>
        /// omitting or setting false leaves it disabled.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sha384 Domain#sha384}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sha384", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sha384
        {
            get
            {
                return null;
            }
        }

        /// <summary>Presence-only flag that enables a SHA‑512 PCR bank in the emulated TPM when set to true;</summary>
        /// <remarks>
        /// omitting or setting false leaves it disabled.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sha512 Domain#sha512}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sha512", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sha512
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorActivePcrBanks), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorActivePcrBanks")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendEmulatorActivePcrBanks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Presence-only flag that enables a SHA‑1 PCR bank in the emulated TPM when set to true;</summary>
            /// <remarks>
            /// omitting or setting false leaves it disabled.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sha1 Domain#sha1}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sha1", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Sha1
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Presence-only flag that enables a SHA‑256 PCR bank in the emulated TPM when set to true;</summary>
            /// <remarks>
            /// omitting or setting false leaves it disabled.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sha256 Domain#sha256}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sha256", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Sha256
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Presence-only flag that enables a SHA‑384 PCR bank in the emulated TPM when set to true;</summary>
            /// <remarks>
            /// omitting or setting false leaves it disabled.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sha384 Domain#sha384}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sha384", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Sha384
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Presence-only flag that enables a SHA‑512 PCR bank in the emulated TPM when set to true;</summary>
            /// <remarks>
            /// omitting or setting false leaves it disabled.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sha512 Domain#sha512}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sha512", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Sha512
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
