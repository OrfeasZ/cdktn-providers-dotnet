using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetCryptoAnalysisResults
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_crypto_analysis_results oci_jms_fleet_crypto_analysis_results}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResults), fullyQualifiedName: "oci.dataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResults", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsConfig\"}}]")]
    public class DataOciJmsFleetCryptoAnalysisResults : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_crypto_analysis_results oci_jms_fleet_crypto_analysis_results} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciJmsFleetCryptoAnalysisResults(Constructs.Construct scope, string id, oci.DataOciJmsFleetCryptoAnalysisResults.IDataOciJmsFleetCryptoAnalysisResultsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciJmsFleetCryptoAnalysisResults.IDataOciJmsFleetCryptoAnalysisResultsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetCryptoAnalysisResults(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetCryptoAnalysisResults(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciJmsFleetCryptoAnalysisResults resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciJmsFleetCryptoAnalysisResults to import.</param>
        /// <param name="importFromId">The id of the existing DataOciJmsFleetCryptoAnalysisResults that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciJmsFleetCryptoAnalysisResults to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciJmsFleetCryptoAnalysisResults to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_crypto_analysis_results#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciJmsFleetCryptoAnalysisResults that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciJmsFleetCryptoAnalysisResults to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResults), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciJmsFleetCryptoAnalysisResults.IDataOciJmsFleetCryptoAnalysisResultsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciJmsFleetCryptoAnalysisResults.IDataOciJmsFleetCryptoAnalysisResultsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciJmsFleetCryptoAnalysisResults.IDataOciJmsFleetCryptoAnalysisResultsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAggregationMode")]
        public virtual void ResetAggregationMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingCount")]
        public virtual void ResetFindingCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingCountGreaterThan")]
        public virtual void ResetFindingCountGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostName")]
        public virtual void ResetHostName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedInstanceId")]
        public virtual void ResetManagedInstanceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNonCompliantFindingCount")]
        public virtual void ResetNonCompliantFindingCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNonCompliantFindingCountGreaterThan")]
        public virtual void ResetNonCompliantFindingCountGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeEnd")]
        public virtual void ResetTimeEnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeStart")]
        public virtual void ResetTimeStart()
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
        = GetStaticProperty<string>(typeof(oci.DataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResults))!;

        [JsiiProperty(name: "cryptoAnalysisResultCollection", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionList\"}")]
        public virtual oci.DataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionList CryptoAnalysisResultCollection
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsFilterList\"}")]
        public virtual oci.DataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aggregationModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AggregationModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingCountGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FindingCountGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FindingCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostNameInput
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
        [JsiiProperty(name: "managedInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nonCompliantFindingCountGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NonCompliantFindingCountGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nonCompliantFindingCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NonCompliantFindingCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeEndInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeEndInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "aggregationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AggregationMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "findingCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FindingCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "findingCountGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FindingCountGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
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

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nonCompliantFindingCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NonCompliantFindingCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nonCompliantFindingCountGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NonCompliantFindingCountGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
