using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeListUserGrants
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeListUserGrantsConfig), fullyQualifiedName: "oci.dataOciDataSafeListUserGrants.DataOciDataSafeListUserGrantsConfig")]
    public interface IDataOciDataSafeListUserGrantsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#user_assessment_id DataOciDataSafeListUserGrants#user_assessment_id}.</summary>
        [JsiiProperty(name: "userAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        string UserAssessmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#user_key DataOciDataSafeListUserGrants#user_key}.</summary>
        [JsiiProperty(name: "userKey", typeJson: "{\"primitive\":\"string\"}")]
        string UserKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#depth_level DataOciDataSafeListUserGrants#depth_level}.</summary>
        [JsiiProperty(name: "depthLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DepthLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#depth_level_greater_than_or_equal_to DataOciDataSafeListUserGrants#depth_level_greater_than_or_equal_to}.</summary>
        [JsiiProperty(name: "depthLevelGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DepthLevelGreaterThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#depth_level_less_than DataOciDataSafeListUserGrants#depth_level_less_than}.</summary>
        [JsiiProperty(name: "depthLevelLessThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DepthLevelLessThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#filter DataOciDataSafeListUserGrants#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeListUserGrants.DataOciDataSafeListUserGrantsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#grant_key DataOciDataSafeListUserGrants#grant_key}.</summary>
        [JsiiProperty(name: "grantKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GrantKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#grant_name DataOciDataSafeListUserGrants#grant_name}.</summary>
        [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GrantName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#id DataOciDataSafeListUserGrants#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#privilege_category DataOciDataSafeListUserGrants#privilege_category}.</summary>
        [JsiiProperty(name: "privilegeCategory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivilegeCategory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#privilege_type DataOciDataSafeListUserGrants#privilege_type}.</summary>
        [JsiiProperty(name: "privilegeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivilegeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeListUserGrantsConfig), fullyQualifiedName: "oci.dataOciDataSafeListUserGrants.DataOciDataSafeListUserGrantsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeListUserGrants.IDataOciDataSafeListUserGrantsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#user_assessment_id DataOciDataSafeListUserGrants#user_assessment_id}.</summary>
            [JsiiProperty(name: "userAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserAssessmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#user_key DataOciDataSafeListUserGrants#user_key}.</summary>
            [JsiiProperty(name: "userKey", typeJson: "{\"primitive\":\"string\"}")]
            public string UserKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#depth_level DataOciDataSafeListUserGrants#depth_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "depthLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DepthLevel
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#depth_level_greater_than_or_equal_to DataOciDataSafeListUserGrants#depth_level_greater_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "depthLevelGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DepthLevelGreaterThanOrEqualTo
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#depth_level_less_than DataOciDataSafeListUserGrants#depth_level_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "depthLevelLessThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DepthLevelLessThan
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#filter DataOciDataSafeListUserGrants#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeListUserGrants.DataOciDataSafeListUserGrantsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#grant_key DataOciDataSafeListUserGrants#grant_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grantKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GrantKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#grant_name DataOciDataSafeListUserGrants#grant_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GrantName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#id DataOciDataSafeListUserGrants#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#privilege_category DataOciDataSafeListUserGrants#privilege_category}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privilegeCategory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivilegeCategory
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_list_user_grants#privilege_type DataOciDataSafeListUserGrants#privilege_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privilegeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivilegeType
            {
                get => GetInstanceProperty<string?>();
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
