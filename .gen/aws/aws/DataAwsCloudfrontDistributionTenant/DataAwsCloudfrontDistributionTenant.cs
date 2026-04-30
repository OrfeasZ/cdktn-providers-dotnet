using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCloudfrontDistributionTenant
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/cloudfront_distribution_tenant aws_cloudfront_distribution_tenant}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenant), fullyQualifiedName: "aws.dataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenant", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.dataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantConfig\"}}]")]
    public class DataAwsCloudfrontDistributionTenant : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/cloudfront_distribution_tenant aws_cloudfront_distribution_tenant} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCloudfrontDistributionTenant(Constructs.Construct scope, string id, aws.DataAwsCloudfrontDistributionTenant.IDataAwsCloudfrontDistributionTenantConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsCloudfrontDistributionTenant.IDataAwsCloudfrontDistributionTenantConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontDistributionTenant(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontDistributionTenant(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsCloudfrontDistributionTenant resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsCloudfrontDistributionTenant to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsCloudfrontDistributionTenant that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsCloudfrontDistributionTenant to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsCloudfrontDistributionTenant to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/cloudfront_distribution_tenant#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsCloudfrontDistributionTenant that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsCloudfrontDistributionTenant to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenant), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetArn")]
        public virtual void ResetArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomain")]
        public virtual void ResetDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenant))!;

        [JsiiProperty(name: "connectionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customizations", typeJson: "{\"fqn\":\"aws.dataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantCustomizationsList\"}")]
        public virtual aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantCustomizationsList Customizations
        {
            get => GetInstanceProperty<aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantCustomizationsList>()!;
        }

        [JsiiProperty(name: "distributionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domains", typeJson: "{\"fqn\":\"aws.dataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantDomainsList\"}")]
        public virtual aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantDomainsList Domains
        {
            get => GetInstanceProperty<aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantDomainsList>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedCertificateRequest", typeJson: "{\"fqn\":\"aws.dataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantManagedCertificateRequestList\"}")]
        public virtual aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantManagedCertificateRequestList ManagedCertificateRequest
        {
            get => GetInstanceProperty<aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantManagedCertificateRequestList>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"aws.dataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantParametersList\"}")]
        public virtual aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantParametersList Parameters
        {
            get => GetInstanceProperty<aws.DataAwsCloudfrontDistributionTenant.DataAwsCloudfrontDistributionTenantParametersList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
