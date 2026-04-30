using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbNetwork
{
    [JsiiInterface(nativeType: typeof(IOdbNetworkConfig), fullyQualifiedName: "aws.odbNetwork.OdbNetworkConfig")]
    public interface IOdbNetworkConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The AZ ID of the AZ where the ODB network is located.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#availability_zone_id OdbNetwork#availability_zone_id}
        /// </remarks>
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityZoneId
        {
            get;
        }

        /// <summary>The CIDR range of the backup subnet for the ODB network.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        /// Constraints:
        ///
        /// <list type="bullet">
        /// <description>Must not overlap with the CIDR range of the client subnet.</description>
        /// <description>Must not overlap with the CIDR ranges of the VPCs that are connected to the
        /// ODB network.</description>
        /// <description>Must not use the following CIDR ranges that are reserved by OCI:</description>
        /// <description>100.106.0.0/16 and 100.107.0.0/16</description>
        /// <description>169.254.0.0/16</description>
        /// <description>224.0.0.0 - 239.255.255.255</description>
        /// <description>240.0.0.0 - 255.255.255.255</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#backup_subnet_cidr OdbNetwork#backup_subnet_cidr}
        /// </remarks>
        [JsiiProperty(name: "backupSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        string BackupSubnetCidr
        {
            get;
        }

        /// <summary>The CIDR notation for the network resource.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        /// Constraints:
        ///
        /// <list type="bullet">
        /// <description>Must not overlap with the CIDR range of the backup subnet.</description>
        /// <description>Must not overlap with the CIDR ranges of the VPCs that are connected to the
        /// ODB network.</description>
        /// <description>Must not use the following CIDR ranges that are reserved by OCI:</description>
        /// <description>100.106.0.0/16 and 100.107.0.0/16</description>
        /// <description>169.254.0.0/16</description>
        /// <description>224.0.0.0 - 239.255.255.255</description>
        /// <description>240.0.0.0 - 255.255.255.255</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#client_subnet_cidr OdbNetwork#client_subnet_cidr}
        /// </remarks>
        [JsiiProperty(name: "clientSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        string ClientSubnetCidr
        {
            get;
        }

        /// <summary>The user-friendly name for the odb network. Changing this will force terraform to create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#display_name OdbNetwork#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Specifies the configuration for Amazon S3 access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#s3_access OdbNetwork#s3_access}
        /// </remarks>
        [JsiiProperty(name: "s3Access", typeJson: "{\"primitive\":\"string\"}")]
        string S3Access
        {
            get;
        }

        /// <summary>Specifies the configuration for Zero-ETL access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#zero_etl_access OdbNetwork#zero_etl_access}
        /// </remarks>
        [JsiiProperty(name: "zeroEtlAccess", typeJson: "{\"primitive\":\"string\"}")]
        string ZeroEtlAccess
        {
            get;
        }

        /// <summary>The name of the Availability Zone (AZ) where the odb network is located.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#availability_zone OdbNetwork#availability_zone}
        /// </remarks>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of regions enabled for cross-region restore in the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#cross_region_s3_restore_sources_access OdbNetwork#cross_region_s3_restore_sources_access}
        /// </remarks>
        [JsiiProperty(name: "crossRegionS3RestoreSourcesAccess", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CrossRegionS3RestoreSourcesAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the custom domain that the network is located. custom_domain_name and default_dns_prefix both can't be given.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#custom_domain_name OdbNetwork#custom_domain_name}
        /// </remarks>
        [JsiiProperty(name: "customDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomDomainName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The default DNS prefix for the network resource. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#default_dns_prefix OdbNetwork#default_dns_prefix}
        /// </remarks>
        [JsiiProperty(name: "defaultDnsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultDnsPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set to true deletes associated OCI resources. Default false.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#delete_associated_resources OdbNetwork#delete_associated_resources}
        /// </remarks>
        [JsiiProperty(name: "deleteAssociatedResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteAssociatedResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the configuration for Amazon KMS access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#kms_access OdbNetwork#kms_access}
        /// </remarks>
        [JsiiProperty(name: "kmsAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the endpoint policy for Amazon KMS access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#kms_policy_document OdbNetwork#kms_policy_document}
        /// </remarks>
        [JsiiProperty(name: "kmsPolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsPolicyDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#region OdbNetwork#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the endpoint policy for Amazon S3 access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#s3_policy_document OdbNetwork#s3_policy_document}
        /// </remarks>
        [JsiiProperty(name: "s3PolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3PolicyDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the configuration for Amazon STS access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#sts_access OdbNetwork#sts_access}
        /// </remarks>
        [JsiiProperty(name: "stsAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StsAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the endpoint policy for Amazon STS access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#sts_policy_document OdbNetwork#sts_policy_document}
        /// </remarks>
        [JsiiProperty(name: "stsPolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StsPolicyDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#tags OdbNetwork#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#timeouts OdbNetwork#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OdbNetwork.IOdbNetworkTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbNetworkConfig), fullyQualifiedName: "aws.odbNetwork.OdbNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OdbNetwork.IOdbNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The AZ ID of the AZ where the ODB network is located.</summary>
            /// <remarks>
            /// Changing this will force terraform to create new resource.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#availability_zone_id OdbNetwork#availability_zone_id}
            /// </remarks>
            [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The CIDR range of the backup subnet for the ODB network.</summary>
            /// <remarks>
            /// Changing this will force terraform to create new resource.
            /// Constraints:
            ///
            /// <list type="bullet">
            /// <description>Must not overlap with the CIDR range of the client subnet.</description>
            /// <description>Must not overlap with the CIDR ranges of the VPCs that are connected to the
            /// ODB network.</description>
            /// <description>Must not use the following CIDR ranges that are reserved by OCI:</description>
            /// <description>100.106.0.0/16 and 100.107.0.0/16</description>
            /// <description>169.254.0.0/16</description>
            /// <description>224.0.0.0 - 239.255.255.255</description>
            /// <description>240.0.0.0 - 255.255.255.255</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#backup_subnet_cidr OdbNetwork#backup_subnet_cidr}
            /// </remarks>
            [JsiiProperty(name: "backupSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupSubnetCidr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The CIDR notation for the network resource.</summary>
            /// <remarks>
            /// Changing this will force terraform to create new resource.
            /// Constraints:
            ///
            /// <list type="bullet">
            /// <description>Must not overlap with the CIDR range of the backup subnet.</description>
            /// <description>Must not overlap with the CIDR ranges of the VPCs that are connected to the
            /// ODB network.</description>
            /// <description>Must not use the following CIDR ranges that are reserved by OCI:</description>
            /// <description>100.106.0.0/16 and 100.107.0.0/16</description>
            /// <description>169.254.0.0/16</description>
            /// <description>224.0.0.0 - 239.255.255.255</description>
            /// <description>240.0.0.0 - 255.255.255.255</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#client_subnet_cidr OdbNetwork#client_subnet_cidr}
            /// </remarks>
            [JsiiProperty(name: "clientSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientSubnetCidr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The user-friendly name for the odb network. Changing this will force terraform to create a new resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#display_name OdbNetwork#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the configuration for Amazon S3 access from the ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#s3_access OdbNetwork#s3_access}
            /// </remarks>
            [JsiiProperty(name: "s3Access", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Access
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the configuration for Zero-ETL access from the ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#zero_etl_access OdbNetwork#zero_etl_access}
            /// </remarks>
            [JsiiProperty(name: "zeroEtlAccess", typeJson: "{\"primitive\":\"string\"}")]
            public string ZeroEtlAccess
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the Availability Zone (AZ) where the odb network is located.</summary>
            /// <remarks>
            /// Changing this will force terraform to create new resource
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#availability_zone OdbNetwork#availability_zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The list of regions enabled for cross-region restore in the ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#cross_region_s3_restore_sources_access OdbNetwork#cross_region_s3_restore_sources_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crossRegionS3RestoreSourcesAccess", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CrossRegionS3RestoreSourcesAccess
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The name of the custom domain that the network is located. custom_domain_name and default_dns_prefix both can't be given.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#custom_domain_name OdbNetwork#custom_domain_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomDomainName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The default DNS prefix for the network resource. Changing this will force terraform to create new resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#default_dns_prefix OdbNetwork#default_dns_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultDnsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultDnsPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set to true deletes associated OCI resources. Default false.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#delete_associated_resources OdbNetwork#delete_associated_resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteAssociatedResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteAssociatedResources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies the configuration for Amazon KMS access from the ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#kms_access OdbNetwork#kms_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kmsAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsAccess
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the endpoint policy for Amazon KMS access from the ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#kms_policy_document OdbNetwork#kms_policy_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kmsPolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsPolicyDocument
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#region OdbNetwork#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the endpoint policy for Amazon S3 access from the ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#s3_policy_document OdbNetwork#s3_policy_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3PolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3PolicyDocument
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the configuration for Amazon STS access from the ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#sts_access OdbNetwork#sts_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stsAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StsAccess
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the endpoint policy for Amazon STS access from the ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#sts_policy_document OdbNetwork#sts_policy_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stsPolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StsPolicyDocument
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#tags OdbNetwork#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#timeouts OdbNetwork#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkTimeouts\"}", isOptional: true)]
            public aws.OdbNetwork.IOdbNetworkTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.OdbNetwork.IOdbNetworkTimeouts?>();
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
