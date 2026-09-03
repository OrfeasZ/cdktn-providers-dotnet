using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiByValue(fqn: "aws.datazonePolicyGrant.DatazonePolicyGrantDetail")]
    public class DatazonePolicyGrantDetail : aws.DatazonePolicyGrant.IDatazonePolicyGrantDetail
    {
        private object? _addToProjectMemberPool;

        /// <summary>add_to_project_member_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#add_to_project_member_pool DatazonePolicyGrant#add_to_project_member_pool}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addToProjectMemberPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailAddToProjectMemberPool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AddToProjectMemberPool
        {
            get => _addToProjectMemberPool;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _addToProjectMemberPool = value;
            }
        }

        private object? _createAssetType;

        /// <summary>create_asset_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_asset_type DatazonePolicyGrant#create_asset_type}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateAssetType" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createAssetType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateAssetType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateAssetType
        {
            get => _createAssetType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateAssetType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateAssetType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createAssetType = value;
            }
        }

        private object? _createDomainUnit;

        /// <summary>create_domain_unit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_domain_unit DatazonePolicyGrant#create_domain_unit}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateDomainUnit" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createDomainUnit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateDomainUnit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateDomainUnit
        {
            get => _createDomainUnit;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateDomainUnit[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateDomainUnit).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createDomainUnit = value;
            }
        }

        private object? _createEnvironment;

        /// <summary>create_environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_environment DatazonePolicyGrant#create_environment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createEnvironment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateEnvironment
        {
            get => _createEnvironment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createEnvironment = value;
            }
        }

        private object? _createEnvironmentFromBlueprint;

        /// <summary>create_environment_from_blueprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_environment_from_blueprint DatazonePolicyGrant#create_environment_from_blueprint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentFromBlueprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createEnvironmentFromBlueprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentFromBlueprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateEnvironmentFromBlueprint
        {
            get => _createEnvironmentFromBlueprint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentFromBlueprint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentFromBlueprint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createEnvironmentFromBlueprint = value;
            }
        }

        private object? _createEnvironmentProfile;

        /// <summary>create_environment_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_environment_profile DatazonePolicyGrant#create_environment_profile}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createEnvironmentProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateEnvironmentProfile
        {
            get => _createEnvironmentProfile;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createEnvironmentProfile = value;
            }
        }

        private object? _createFormType;

        /// <summary>create_form_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_form_type DatazonePolicyGrant#create_form_type}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateFormType" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createFormType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateFormType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateFormType
        {
            get => _createFormType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateFormType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateFormType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createFormType = value;
            }
        }

        private object? _createGlossary;

        /// <summary>create_glossary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_glossary DatazonePolicyGrant#create_glossary}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createGlossary", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateGlossary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateGlossary
        {
            get => _createGlossary;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createGlossary = value;
            }
        }

        private object? _createProject;

        /// <summary>create_project block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_project DatazonePolicyGrant#create_project}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProject" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createProject", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateProject\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateProject
        {
            get => _createProject;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProject[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProject).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createProject = value;
            }
        }

        private object? _createProjectFromProjectProfile;

        /// <summary>create_project_from_project_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#create_project_from_project_profile DatazonePolicyGrant#create_project_from_project_profile}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProjectFromProjectProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createProjectFromProjectProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectFromProjectProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreateProjectFromProjectProfile
        {
            get => _createProjectFromProjectProfile;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProjectFromProjectProfile[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProjectFromProjectProfile).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createProjectFromProjectProfile = value;
            }
        }

        private object? _delegateCreateEnvironmentProfile;

        /// <summary>delegate_create_environment_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#delegate_create_environment_profile DatazonePolicyGrant#delegate_create_environment_profile}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailDelegateCreateEnvironmentProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "delegateCreateEnvironmentProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailDelegateCreateEnvironmentProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DelegateCreateEnvironmentProfile
        {
            get => _delegateCreateEnvironmentProfile;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailDelegateCreateEnvironmentProfile[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailDelegateCreateEnvironmentProfile).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _delegateCreateEnvironmentProfile = value;
            }
        }

        private object? _overrideDomainUnitOwners;

        /// <summary>override_domain_unit_owners block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#override_domain_unit_owners DatazonePolicyGrant#override_domain_unit_owners}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideDomainUnitOwners" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrideDomainUnitOwners", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailOverrideDomainUnitOwners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OverrideDomainUnitOwners
        {
            get => _overrideDomainUnitOwners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideDomainUnitOwners[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideDomainUnitOwners).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _overrideDomainUnitOwners = value;
            }
        }

        private object? _overrideProjectOwners;

        /// <summary>override_project_owners block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#override_project_owners DatazonePolicyGrant#override_project_owners}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideProjectOwners" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrideProjectOwners", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailOverrideProjectOwners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OverrideProjectOwners
        {
            get => _overrideProjectOwners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideProjectOwners[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideProjectOwners).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _overrideProjectOwners = value;
            }
        }

        private object? _useAssetType;

        /// <summary>use_asset_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#use_asset_type DatazonePolicyGrant#use_asset_type}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useAssetType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailUseAssetType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UseAssetType
        {
            get => _useAssetType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _useAssetType = value;
            }
        }
    }
}
