using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowSqlEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint oci_dataflow_sql_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataflowSqlEndpoint.DataflowSqlEndpoint), fullyQualifiedName: "oci.dataflowSqlEndpoint.DataflowSqlEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointConfig\"}}]")]
    public class DataflowSqlEndpoint : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint oci_dataflow_sql_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataflowSqlEndpoint(Constructs.Construct scope, string id, oci.DataflowSqlEndpoint.IDataflowSqlEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataflowSqlEndpoint.IDataflowSqlEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataflowSqlEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataflowSqlEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataflowSqlEndpoint resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataflowSqlEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing DataflowSqlEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataflowSqlEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataflowSqlEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataflowSqlEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataflowSqlEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataflowSqlEndpoint.DataflowSqlEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDriverShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointDriverShapeConfig\"}}]")]
        public virtual void PutDriverShapeConfig(oci.DataflowSqlEndpoint.IDataflowSqlEndpointDriverShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataflowSqlEndpoint.IDataflowSqlEndpointDriverShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExecutorShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointExecutorShapeConfig\"}}]")]
        public virtual void PutExecutorShapeConfig(oci.DataflowSqlEndpoint.IDataflowSqlEndpointExecutorShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataflowSqlEndpoint.IDataflowSqlEndpointExecutorShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataflowSqlEndpoint.IDataflowSqlEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataflowSqlEndpoint.IDataflowSqlEndpointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDriverShapeConfig")]
        public virtual void ResetDriverShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutorShapeConfig")]
        public virtual void ResetExecutorShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSparkAdvancedConfigurations")]
        public virtual void ResetSparkAdvancedConfigurations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.DataflowSqlEndpoint.DataflowSqlEndpoint))!;

        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointDriverShapeConfigOutputReference\"}")]
        public virtual oci.DataflowSqlEndpoint.DataflowSqlEndpointDriverShapeConfigOutputReference DriverShapeConfig
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.DataflowSqlEndpointDriverShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointExecutorShapeConfigOutputReference\"}")]
        public virtual oci.DataflowSqlEndpoint.DataflowSqlEndpointExecutorShapeConfigOutputReference ExecutorShapeConfig
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.DataflowSqlEndpointExecutorShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "jdbcEndpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JdbcEndpointUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lakeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LakeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationOutputReference\"}")]
        public virtual oci.DataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "stateMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateMessage
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointTimeoutsOutputReference\"}")]
        public virtual oci.DataflowSqlEndpoint.DataflowSqlEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.DataflowSqlEndpointTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarehouseBucketUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "driverShapeConfigInput", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointDriverShapeConfig\"}", isOptional: true)]
        public virtual oci.DataflowSqlEndpoint.IDataflowSqlEndpointDriverShapeConfig? DriverShapeConfigInput
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.IDataflowSqlEndpointDriverShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "driverShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DriverShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executorShapeConfigInput", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointExecutorShapeConfig\"}", isOptional: true)]
        public virtual oci.DataflowSqlEndpoint.IDataflowSqlEndpointExecutorShapeConfig? ExecutorShapeConfigInput
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.IDataflowSqlEndpointExecutorShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executorShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutorShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxExecutorCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxExecutorCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metastoreIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetastoreIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minExecutorCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinExecutorCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkAdvancedConfigurationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SparkAdvancedConfigurationsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlEndpointVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlEndpointVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DriverShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutorShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxExecutorCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxExecutorCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metastoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetastoreId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minExecutorCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinExecutorCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sparkAdvancedConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SparkAdvancedConfigurations
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlEndpointVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlEndpointVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
