using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolume
{
    [JsiiInterface(nativeType: typeof(ICoreVolumeSourceDetails), fullyQualifiedName: "oci.coreVolume.CoreVolumeSourceDetails")]
    public interface ICoreVolumeSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#type CoreVolume#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#change_block_size_in_bytes CoreVolume#change_block_size_in_bytes}.</summary>
        [JsiiProperty(name: "changeBlockSizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ChangeBlockSizeInBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#first_backup_id CoreVolume#first_backup_id}.</summary>
        [JsiiProperty(name: "firstBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirstBackupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#id CoreVolume#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#second_backup_id CoreVolume#second_backup_id}.</summary>
        [JsiiProperty(name: "secondBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecondBackupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVolumeSourceDetails), fullyQualifiedName: "oci.coreVolume.CoreVolumeSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVolume.ICoreVolumeSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#type CoreVolume#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#change_block_size_in_bytes CoreVolume#change_block_size_in_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "changeBlockSizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ChangeBlockSizeInBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#first_backup_id CoreVolume#first_backup_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firstBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirstBackupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#id CoreVolume#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#second_backup_id CoreVolume#second_backup_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecondBackupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
