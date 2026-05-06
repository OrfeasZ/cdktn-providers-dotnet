using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NosqlConfiguration
{
    [JsiiInterface(nativeType: typeof(INosqlConfigurationKmsKey), fullyQualifiedName: "oci.nosqlConfiguration.NosqlConfigurationKmsKey")]
    public interface INosqlConfigurationKmsKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#id NosqlConfiguration#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#kms_key_state NosqlConfiguration#kms_key_state}.</summary>
        [JsiiProperty(name: "kmsKeyState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#kms_vault_id NosqlConfiguration#kms_vault_id}.</summary>
        [JsiiProperty(name: "kmsVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsVaultId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#time_created NosqlConfiguration#time_created}.</summary>
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeCreated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#time_updated NosqlConfiguration#time_updated}.</summary>
        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUpdated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INosqlConfigurationKmsKey), fullyQualifiedName: "oci.nosqlConfiguration.NosqlConfigurationKmsKey")]
        internal sealed class _Proxy : DeputyBase, oci.NosqlConfiguration.INosqlConfigurationKmsKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#id NosqlConfiguration#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#kms_key_state NosqlConfiguration#kms_key_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#kms_vault_id NosqlConfiguration#kms_vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsVaultId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#time_created NosqlConfiguration#time_created}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeCreated
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_configuration#time_updated NosqlConfiguration#time_updated}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUpdated
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
