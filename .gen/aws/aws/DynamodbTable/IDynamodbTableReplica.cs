using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableReplica), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableReplica")]
    public interface IDynamodbTableReplica
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#region_name DynamodbTable#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#consistency_mode DynamodbTable#consistency_mode}.</summary>
        [JsiiProperty(name: "consistencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsistencyMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#deletion_protection_enabled DynamodbTable#deletion_protection_enabled}.</summary>
        [JsiiProperty(name: "deletionProtectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeletionProtectionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#kms_key_arn DynamodbTable#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#point_in_time_recovery DynamodbTable#point_in_time_recovery}.</summary>
        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PointInTimeRecovery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#propagate_tags DynamodbTable#propagate_tags}.</summary>
        [JsiiProperty(name: "propagateTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PropagateTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableReplica), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableReplica")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableReplica
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#region_name DynamodbTable#region_name}.</summary>
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#consistency_mode DynamodbTable#consistency_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "consistencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsistencyMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#deletion_protection_enabled DynamodbTable#deletion_protection_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deletionProtectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeletionProtectionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#kms_key_arn DynamodbTable#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#point_in_time_recovery DynamodbTable#point_in_time_recovery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PointInTimeRecovery
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_table#propagate_tags DynamodbTable#propagate_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "propagateTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PropagateTags
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
