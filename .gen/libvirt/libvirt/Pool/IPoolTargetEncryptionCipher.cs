using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolTargetEncryptionCipher), fullyQualifiedName: "libvirt.pool.PoolTargetEncryptionCipher")]
    public interface IPoolTargetEncryptionCipher
    {
        /// <summary>Sets the hash algorithm used with the encryption cipher (for example `sha256`), with the exact value being user-provided but expected to be supported by the chosen encryption format.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#hash Pool#hash}
        /// </remarks>
        [JsiiProperty(name: "hash", typeJson: "{\"primitive\":\"string\"}")]
        string Hash
        {
            get;
        }

        /// <summary>Sets the cipher mode of operation (for example `cbc` or `xts`), with the value user-provided and constrained by the encryption backend’s supported modes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#mode Pool#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Sets the base cipher algorithm name (for example `aes`), with the value user-provided and expected to be a valid algorithm for the image’s encryption format.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Sets the cipher key size in bits for the encrypted storage volume (user-provided integer such as 128, 256, etc.).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#size Pool#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolTargetEncryptionCipher), fullyQualifiedName: "libvirt.pool.PoolTargetEncryptionCipher")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolTargetEncryptionCipher
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the hash algorithm used with the encryption cipher (for example `sha256`), with the exact value being user-provided but expected to be supported by the chosen encryption format.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#hash Pool#hash}
            /// </remarks>
            [JsiiProperty(name: "hash", typeJson: "{\"primitive\":\"string\"}")]
            public string Hash
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the cipher mode of operation (for example `cbc` or `xts`), with the value user-provided and constrained by the encryption backend’s supported modes.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#mode Pool#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the base cipher algorithm name (for example `aes`), with the value user-provided and expected to be a valid algorithm for the image’s encryption format.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the cipher key size in bits for the encrypted storage volume (user-provided integer such as 128, 256, etc.).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#size Pool#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
