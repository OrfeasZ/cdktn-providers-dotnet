using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDbmulticloudOracleDbAzureVaultAssociation
{
    [JsiiInterface(nativeType: typeof(IDataOciDbmulticloudOracleDbAzureVaultAssociationConfig), fullyQualifiedName: "oci.dataOciDbmulticloudOracleDbAzureVaultAssociation.DataOciDbmulticloudOracleDbAzureVaultAssociationConfig")]
    public interface IDataOciDbmulticloudOracleDbAzureVaultAssociationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dbmulticloud_oracle_db_azure_vault_association#oracle_db_azure_vault_association_id DataOciDbmulticloudOracleDbAzureVaultAssociation#oracle_db_azure_vault_association_id}.</summary>
        [JsiiProperty(name: "oracleDbAzureVaultAssociationId", typeJson: "{\"primitive\":\"string\"}")]
        string OracleDbAzureVaultAssociationId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDbmulticloudOracleDbAzureVaultAssociationConfig), fullyQualifiedName: "oci.dataOciDbmulticloudOracleDbAzureVaultAssociation.DataOciDbmulticloudOracleDbAzureVaultAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDbmulticloudOracleDbAzureVaultAssociation.IDataOciDbmulticloudOracleDbAzureVaultAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dbmulticloud_oracle_db_azure_vault_association#oracle_db_azure_vault_association_id DataOciDbmulticloudOracleDbAzureVaultAssociation#oracle_db_azure_vault_association_id}.</summary>
            [JsiiProperty(name: "oracleDbAzureVaultAssociationId", typeJson: "{\"primitive\":\"string\"}")]
            public string OracleDbAzureVaultAssociationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
