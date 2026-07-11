using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.ManagedDisk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.managedDisk.ManagedDiskEncryption")]
    public class ManagedDiskEncryption : azurestack.ManagedDisk.IManagedDiskEncryption
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#enabled ManagedDisk#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>disk_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#disk_encryption_key ManagedDisk#disk_encryption_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKey\"}", isOptional: true)]
        public azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey? DiskEncryptionKey
        {
            get;
            set;
        }

        /// <summary>key_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#key_encryption_key ManagedDisk#key_encryption_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionKeyEncryptionKey\"}", isOptional: true)]
        public azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey? KeyEncryptionKey
        {
            get;
            set;
        }
    }
}
