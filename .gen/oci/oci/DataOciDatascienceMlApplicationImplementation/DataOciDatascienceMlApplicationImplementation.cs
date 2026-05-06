using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceMlApplicationImplementation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_ml_application_implementation oci_datascience_ml_application_implementation}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementation), fullyQualifiedName: "oci.dataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationConfig\"}}]")]
    public class DataOciDatascienceMlApplicationImplementation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_ml_application_implementation oci_datascience_ml_application_implementation} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatascienceMlApplicationImplementation(Constructs.Construct scope, string id, oci.DataOciDatascienceMlApplicationImplementation.IDataOciDatascienceMlApplicationImplementationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatascienceMlApplicationImplementation.IDataOciDatascienceMlApplicationImplementationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceMlApplicationImplementation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceMlApplicationImplementation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatascienceMlApplicationImplementation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatascienceMlApplicationImplementation to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatascienceMlApplicationImplementation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatascienceMlApplicationImplementation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatascienceMlApplicationImplementation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_ml_application_implementation#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatascienceMlApplicationImplementation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatascienceMlApplicationImplementation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementation))!;

        [JsiiProperty(name: "allowedMigrationDestinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedMigrationDestinations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "applicationComponents", typeJson: "{\"fqn\":\"oci.dataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationApplicationComponentsList\"}")]
        public virtual oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationApplicationComponentsList ApplicationComponents
        {
            get => GetInstanceProperty<oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationApplicationComponentsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationSchema", typeJson: "{\"fqn\":\"oci.dataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationConfigurationSchemaList\"}")]
        public virtual oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationConfigurationSchemaList ConfigurationSchema
        {
            get => GetInstanceProperty<oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationConfigurationSchemaList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"oci.dataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationLoggingList\"}")]
        public virtual oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationLoggingList Logging
        {
            get => GetInstanceProperty<oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationLoggingList>()!;
        }

        [JsiiProperty(name: "mlApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mlApplicationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mlApplicationPackage", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap MlApplicationPackage
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "mlApplicationPackageArguments", typeJson: "{\"fqn\":\"oci.dataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationMlApplicationPackageArgumentsList\"}")]
        public virtual oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationMlApplicationPackageArgumentsList MlApplicationPackageArguments
        {
            get => GetInstanceProperty<oci.DataOciDatascienceMlApplicationImplementation.DataOciDatascienceMlApplicationImplementationMlApplicationPackageArgumentsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opcMlAppPackageArgs", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap OpcMlAppPackageArgs
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mlApplicationImplementationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MlApplicationImplementationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "mlApplicationImplementationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationImplementationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
