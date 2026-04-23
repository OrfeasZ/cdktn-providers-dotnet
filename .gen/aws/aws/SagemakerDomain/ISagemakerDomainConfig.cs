using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainConfig), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainConfig")]
    public interface ISagemakerDomainConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#auth_mode SagemakerDomain#auth_mode}.</summary>
        [JsiiProperty(name: "authMode", typeJson: "{\"primitive\":\"string\"}")]
        string AuthMode
        {
            get;
        }

        /// <summary>default_user_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#default_user_settings SagemakerDomain#default_user_settings}
        /// </remarks>
        [JsiiProperty(name: "defaultUserSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettings\"}")]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettings DefaultUserSettings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#domain_name SagemakerDomain#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#subnet_ids SagemakerDomain#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#vpc_id SagemakerDomain#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#app_network_access_type SagemakerDomain#app_network_access_type}.</summary>
        [JsiiProperty(name: "appNetworkAccessType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppNetworkAccessType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#app_security_group_management SagemakerDomain#app_security_group_management}.</summary>
        [JsiiProperty(name: "appSecurityGroupManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppSecurityGroupManagement
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_space_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#default_space_settings SagemakerDomain#default_space_settings}
        /// </remarks>
        [JsiiProperty(name: "defaultSpaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettings? DefaultSpaceSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>domain_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#domain_settings SagemakerDomain#domain_settings}
        /// </remarks>
        [JsiiProperty(name: "domainSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDomainSettings? DomainSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#id SagemakerDomain#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#kms_key_id SagemakerDomain#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#region SagemakerDomain#region}
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

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#retention_policy SagemakerDomain#retention_policy}
        /// </remarks>
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainRetentionPolicy? RetentionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#tag_propagation SagemakerDomain#tag_propagation}.</summary>
        [JsiiProperty(name: "tagPropagation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagPropagation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#tags SagemakerDomain#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#tags_all SagemakerDomain#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainConfig), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#auth_mode SagemakerDomain#auth_mode}.</summary>
            [JsiiProperty(name: "authMode", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>default_user_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#default_user_settings SagemakerDomain#default_user_settings}
            /// </remarks>
            [JsiiProperty(name: "defaultUserSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettings\"}")]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettings DefaultUserSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettings>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#domain_name SagemakerDomain#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#subnet_ids SagemakerDomain#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#vpc_id SagemakerDomain#vpc_id}.</summary>
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#app_network_access_type SagemakerDomain#app_network_access_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appNetworkAccessType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppNetworkAccessType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#app_security_group_management SagemakerDomain#app_security_group_management}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appSecurityGroupManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppSecurityGroupManagement
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>default_space_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#default_space_settings SagemakerDomain#default_space_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSpaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettings? DefaultSpaceSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettings?>();
            }

            /// <summary>domain_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#domain_settings SagemakerDomain#domain_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domainSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDomainSettings? DomainSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#id SagemakerDomain#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#kms_key_id SagemakerDomain#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#region SagemakerDomain#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#retention_policy SagemakerDomain#retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainRetentionPolicy\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainRetentionPolicy? RetentionPolicy
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainRetentionPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#tag_propagation SagemakerDomain#tag_propagation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagPropagation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagPropagation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#tags SagemakerDomain#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#tags_all SagemakerDomain#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
