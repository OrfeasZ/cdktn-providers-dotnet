using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database oci_distributed_database_distributed_autonomous_database}.</summary>
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabase), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseConfig\"}}]")]
    public class DistributedDatabaseDistributedAutonomousDatabase : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database oci_distributed_database_distributed_autonomous_database} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DistributedDatabaseDistributedAutonomousDatabase(Constructs.Construct scope, string id, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedAutonomousDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedAutonomousDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DistributedDatabaseDistributedAutonomousDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DistributedDatabaseDistributedAutonomousDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DistributedDatabaseDistributedAutonomousDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DistributedDatabaseDistributedAutonomousDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DistributedDatabaseDistributedAutonomousDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DistributedDatabaseDistributedAutonomousDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DistributedDatabaseDistributedAutonomousDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails" />)[]</param>
        [JsiiMethod(name: "putCatalogDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCatalogDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDbBackupConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig\"}}]")]
        public virtual void PutDbBackupConfig(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations" />)[]</param>
        [JsiiMethod(name: "putPatchOperations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabasePatchOperations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPatchOperations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetails" />)[]</param>
        [JsiiMethod(name: "putShardDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutShardDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putValidateNetworkDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails\"}}]")]
        public virtual void PutValidateNetworkDetails(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCaBundleId")]
        public virtual void ResetCaBundleId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateId")]
        public virtual void ResetCertificateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChangeDbBackupConfigTrigger")]
        public virtual void ResetChangeDbBackupConfigTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChunks")]
        public virtual void ResetChunks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigureGsmWalletTrigger")]
        public virtual void ResetConfigureGsmWalletTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigureShardingIsRebalanceRequired")]
        public virtual void ResetConfigureShardingIsRebalanceRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigureShardingTrigger")]
        public virtual void ResetConfigureShardingTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbBackupConfig")]
        public virtual void ResetDbBackupConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDownloadGsmCertificateSigningRequestTrigger")]
        public virtual void ResetDownloadGsmCertificateSigningRequestTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenerateGsmCertificateSigningRequestTrigger")]
        public virtual void ResetGenerateGsmCertificateSigningRequestTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenerateGsmCertificateSigningRequestTriggerCaBundleId")]
        public virtual void ResetGenerateGsmCertificateSigningRequestTriggerCaBundleId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenerateWalletPassword")]
        public virtual void ResetGenerateWalletPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenerateWalletTrigger")]
        public virtual void ResetGenerateWalletTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetListenerPortTls")]
        public virtual void ResetListenerPortTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMoveReplicationUnitTrigger")]
        public virtual void ResetMoveReplicationUnitTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchOperations")]
        public virtual void ResetPatchOperations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecreateFailedResourceTrigger")]
        public virtual void ResetRecreateFailedResourceTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationFactor")]
        public virtual void ResetReplicationFactor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationMethod")]
        public virtual void ResetReplicationMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationUnit")]
        public virtual void ResetReplicationUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartDatabaseTrigger")]
        public virtual void ResetStartDatabaseTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStopDatabaseTrigger")]
        public virtual void ResetStopDatabaseTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUploadCaSignedCertificate")]
        public virtual void ResetUploadCaSignedCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUploadSignedCertificateAndGenerateWalletTrigger")]
        public virtual void ResetUploadSignedCertificateAndGenerateWalletTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidateCaBundleTrigger")]
        public virtual void ResetValidateCaBundleTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidateNetworkDetails")]
        public virtual void ResetValidateNetworkDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidateNetworkTrigger")]
        public virtual void ResetValidateNetworkTrigger()
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
        = GetStaticProperty<string>(typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabase))!;

        [JsiiProperty(name: "catalogDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsList\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsList CatalogDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsList>()!;
        }

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseConnectionStringsList\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseConnectionStringsList>()!;
        }

        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigOutputReference DbBackupConfig
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigOutputReference>()!;
        }

        [JsiiProperty(name: "downloadedGsmCsrPem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DownloadedGsmCsrPem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "effectiveReplicationUnit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EffectiveReplicationUnit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "generateWalletDownloadedWalletContentLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateWalletDownloadedWalletContentLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "generateWalletDownloadedWalletEtag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateWalletDownloadedWalletEtag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generateWalletDownloadedWalletLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateWalletDownloadedWalletLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generateWalletDownloadedWalletZipBase64", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateWalletDownloadedWalletZipBase64
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gsmDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseGsmDetailsList\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseGsmDetailsList GsmDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseGsmDetailsList>()!;
        }

        [JsiiProperty(name: "latestGsmImage", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseLatestGsmImageList\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseLatestGsmImageList LatestGsmImage
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseLatestGsmImageList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseMetadataList\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseMetadataList>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabasePatchOperationsList\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabasePatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabasePatchOperationsList>()!;
        }

        [JsiiProperty(name: "shardDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetailsList\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetailsList ShardDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetailsList>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeoutsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validateNetworkDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetailsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetailsOutputReference ValidateNetworkDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "caBundleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaBundleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "catalogDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CatalogDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "changeDbBackupConfigTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ChangeDbBackupConfigTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "characterSetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CharacterSetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "chunksInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ChunksInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configureGsmWalletTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConfigureGsmWalletTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configureShardingIsRebalanceRequiredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ConfigureShardingIsRebalanceRequiredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configureShardingTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConfigureShardingTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbBackupConfigInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig? DbBackupConfigInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbDeploymentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbDeploymentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbWorkloadInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbWorkloadInput
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
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "downloadGsmCertificateSigningRequestTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DownloadGsmCertificateSigningRequestTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generateGsmCertificateSigningRequestTriggerCaBundleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GenerateGsmCertificateSigningRequestTriggerCaBundleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generateGsmCertificateSigningRequestTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GenerateGsmCertificateSigningRequestTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generateWalletPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GenerateWalletPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generateWalletTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GenerateWalletTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ListenerPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerPortTlsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ListenerPortTlsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "moveReplicationUnitTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MoveReplicationUnitTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ncharacterSetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NcharacterSetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onsPortLocalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OnsPortLocalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onsPortRemoteInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OnsPortRemoteInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabasePatchOperations" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patchOperationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PatchOperationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PrivateEndpointIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recreateFailedResourceTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RecreateFailedResourceTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicationFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationUnitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicationUnitInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shardDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ShardDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shardingMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShardingMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startDatabaseTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StartDatabaseTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stopDatabaseTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StopDatabaseTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uploadCaSignedCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UploadCaSignedCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uploadSignedCertificateAndGenerateWalletTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UploadSignedCertificateAndGenerateWalletTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validateCaBundleTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ValidateCaBundleTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validateNetworkDetailsInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails? ValidateNetworkDetailsInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validateNetworkTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ValidateNetworkTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaBundleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "changeDbBackupConfigTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ChangeDbBackupConfigTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "chunks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Chunks
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configureGsmWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureGsmWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "configureShardingIsRebalanceRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ConfigureShardingIsRebalanceRequired
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureShardingTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbDeploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbDeploymentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbWorkload
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "downloadGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DownloadGsmCertificateSigningRequestTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "generateGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateGsmCertificateSigningRequestTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "generateGsmCertificateSigningRequestTriggerCaBundleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateGsmCertificateSigningRequestTriggerCaBundleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "generateWalletPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateWalletPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenerPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenerPortTls
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "moveReplicationUnitTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MoveReplicationUnitTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NcharacterSet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnsPortLocal
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnsPortRemote
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateEndpointIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recreateFailedResourceTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecreateFailedResourceTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationUnit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationUnit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shardingMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardingMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartDatabaseTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StopDatabaseTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uploadCaSignedCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UploadCaSignedCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uploadSignedCertificateAndGenerateWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UploadSignedCertificateAndGenerateWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validateCaBundleTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateCaBundleTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateNetworkTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
