using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceMlApplicationInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_ml_application_instance oci_datascience_ml_application_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstance), fullyQualifiedName: "oci.dataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstanceConfig\"}}]")]
    public class DataOciDatascienceMlApplicationInstance : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_ml_application_instance oci_datascience_ml_application_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatascienceMlApplicationInstance(Constructs.Construct scope, string id, oci.DataOciDatascienceMlApplicationInstance.IDataOciDatascienceMlApplicationInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatascienceMlApplicationInstance.IDataOciDatascienceMlApplicationInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceMlApplicationInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceMlApplicationInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatascienceMlApplicationInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatascienceMlApplicationInstance to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatascienceMlApplicationInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatascienceMlApplicationInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatascienceMlApplicationInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_ml_application_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatascienceMlApplicationInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatascienceMlApplicationInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstance))!;

        [JsiiProperty(name: "authConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstanceAuthConfigurationList\"}")]
        public virtual oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstanceAuthConfigurationList AuthConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstanceAuthConfigurationList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstanceConfigurationList\"}")]
        public virtual oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstanceConfigurationList Configuration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstanceConfigurationList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleSubstate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleSubstate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mlApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mlApplicationImplementationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationImplementationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mlApplicationImplementationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationImplementationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mlApplicationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "predictionEndpointDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstancePredictionEndpointDetailsList\"}")]
        public virtual oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstancePredictionEndpointDetailsList PredictionEndpointDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceMlApplicationInstance.DataOciDatascienceMlApplicationInstancePredictionEndpointDetailsList>()!;
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
        [JsiiProperty(name: "mlApplicationInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MlApplicationInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "mlApplicationInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
