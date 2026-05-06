using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsGlueCatalog
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/data-sources/glue_catalog aws_glue_catalog}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsGlueCatalog.DataAwsGlueCatalog), fullyQualifiedName: "aws.dataAwsGlueCatalog.DataAwsGlueCatalog", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsGlueCatalog.DataAwsGlueCatalogConfig\"}}]")]
    public class DataAwsGlueCatalog : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/data-sources/glue_catalog aws_glue_catalog} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsGlueCatalog(Constructs.Construct scope, string id, aws.DataAwsGlueCatalog.IDataAwsGlueCatalogConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsGlueCatalog.IDataAwsGlueCatalogConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueCatalog(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueCatalog(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsGlueCatalog resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsGlueCatalog to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsGlueCatalog that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsGlueCatalog to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsGlueCatalog to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/data-sources/glue_catalog#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsGlueCatalog that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsGlueCatalog to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsGlueCatalog.DataAwsGlueCatalog), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsGlueCatalog.DataAwsGlueCatalog))!;

        [JsiiProperty(name: "allowFullTableExternalDataAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowFullTableExternalDataAccess
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "catalogProperties", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalog.DataAwsGlueCatalogCatalogPropertiesList\"}")]
        public virtual aws.DataAwsGlueCatalog.DataAwsGlueCatalogCatalogPropertiesList CatalogProperties
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalog.DataAwsGlueCatalogCatalogPropertiesList>()!;
        }

        [JsiiProperty(name: "createDatabaseDefaultPermissions", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalog.DataAwsGlueCatalogCreateDatabaseDefaultPermissionsList\"}")]
        public virtual aws.DataAwsGlueCatalog.DataAwsGlueCatalogCreateDatabaseDefaultPermissionsList CreateDatabaseDefaultPermissions
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalog.DataAwsGlueCatalogCreateDatabaseDefaultPermissionsList>()!;
        }

        [JsiiProperty(name: "createTableDefaultPermissions", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalog.DataAwsGlueCatalogCreateTableDefaultPermissionsList\"}")]
        public virtual aws.DataAwsGlueCatalog.DataAwsGlueCatalogCreateTableDefaultPermissionsList CreateTableDefaultPermissions
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalog.DataAwsGlueCatalogCreateTableDefaultPermissionsList>()!;
        }

        [JsiiProperty(name: "createTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "federatedCatalog", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalog.DataAwsGlueCatalogFederatedCatalogList\"}")]
        public virtual aws.DataAwsGlueCatalog.DataAwsGlueCatalogFederatedCatalogList FederatedCatalog
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalog.DataAwsGlueCatalogFederatedCatalogList>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Parameters
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetRedshiftCatalog", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalog.DataAwsGlueCatalogTargetRedshiftCatalogList\"}")]
        public virtual aws.DataAwsGlueCatalog.DataAwsGlueCatalogTargetRedshiftCatalogList TargetRedshiftCatalog
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalog.DataAwsGlueCatalogTargetRedshiftCatalogList>()!;
        }

        [JsiiProperty(name: "updateTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
