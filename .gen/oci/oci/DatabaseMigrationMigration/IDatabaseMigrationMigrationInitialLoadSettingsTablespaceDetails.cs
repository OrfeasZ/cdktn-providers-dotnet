using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails")]
    public interface IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#target_type DatabaseMigrationMigration#target_type}.</summary>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        string TargetType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#block_size_in_kbs DatabaseMigrationMigration#block_size_in_kbs}.</summary>
        [JsiiProperty(name: "blockSizeInKbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockSizeInKbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#extend_size_in_mbs DatabaseMigrationMigration#extend_size_in_mbs}.</summary>
        [JsiiProperty(name: "extendSizeInMbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExtendSizeInMbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_auto_create DatabaseMigrationMigration#is_auto_create}.</summary>
        [JsiiProperty(name: "isAutoCreate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoCreate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_big_file DatabaseMigrationMigration#is_big_file}.</summary>
        [JsiiProperty(name: "isBigFile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsBigFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#remap_target DatabaseMigrationMigration#remap_target}.</summary>
        [JsiiProperty(name: "remapTarget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemapTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#target_type DatabaseMigrationMigration#target_type}.</summary>
            [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#block_size_in_kbs DatabaseMigrationMigration#block_size_in_kbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockSizeInKbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockSizeInKbs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#extend_size_in_mbs DatabaseMigrationMigration#extend_size_in_mbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "extendSizeInMbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExtendSizeInMbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_auto_create DatabaseMigrationMigration#is_auto_create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoCreate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoCreate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_big_file DatabaseMigrationMigration#is_big_file}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isBigFile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsBigFile
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#remap_target DatabaseMigrationMigration#remap_target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remapTarget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemapTarget
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
