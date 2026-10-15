using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAwsKeyPool
{
    [JsiiInterface(nativeType: typeof(IDbmulticloudOracleDbAwsKeyPoolTimeouts), fullyQualifiedName: "oci.dbmulticloudOracleDbAwsKeyPool.DbmulticloudOracleDbAwsKeyPoolTimeouts")]
    public interface IDbmulticloudOracleDbAwsKeyPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#create DbmulticloudOracleDbAwsKeyPool#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#delete DbmulticloudOracleDbAwsKeyPool#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#update DbmulticloudOracleDbAwsKeyPool#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbmulticloudOracleDbAwsKeyPoolTimeouts), fullyQualifiedName: "oci.dbmulticloudOracleDbAwsKeyPool.DbmulticloudOracleDbAwsKeyPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DbmulticloudOracleDbAwsKeyPool.IDbmulticloudOracleDbAwsKeyPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#create DbmulticloudOracleDbAwsKeyPool#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#delete DbmulticloudOracleDbAwsKeyPool#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#update DbmulticloudOracleDbAwsKeyPool#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
