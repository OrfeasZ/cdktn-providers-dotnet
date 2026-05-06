using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessmentSecurityFeatures
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_assessment_security_features oci_data_safe_security_assessment_security_features}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeatures), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeatures", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesConfig\"}}]")]
    public class DataOciDataSafeSecurityAssessmentSecurityFeatures : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_assessment_security_features oci_data_safe_security_assessment_security_features} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSecurityAssessmentSecurityFeatures(Constructs.Construct scope, string id, oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.IDataOciDataSafeSecurityAssessmentSecurityFeaturesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.IDataOciDataSafeSecurityAssessmentSecurityFeaturesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentSecurityFeatures(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentSecurityFeatures(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSecurityAssessmentSecurityFeatures resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSecurityAssessmentSecurityFeatures to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSecurityAssessmentSecurityFeatures that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSecurityAssessmentSecurityFeatures to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSecurityAssessmentSecurityFeatures to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_assessment_security_features#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSecurityAssessmentSecurityFeatures that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSecurityAssessmentSecurityFeatures to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeatures), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.IDataOciDataSafeSecurityAssessmentSecurityFeaturesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.IDataOciDataSafeSecurityAssessmentSecurityFeaturesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.IDataOciDataSafeSecurityAssessmentSecurityFeaturesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessLevel")]
        public virtual void ResetAccessLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentIdInSubtree")]
        public virtual void ResetCompartmentIdInSubtree()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithColumnEncryption")]
        public virtual void ResetTargetsWithColumnEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithDatabaseVault")]
        public virtual void ResetTargetsWithDatabaseVault()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithExternalAuthentication")]
        public virtual void ResetTargetsWithExternalAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithFineGrainedAudit")]
        public virtual void ResetTargetsWithFineGrainedAudit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithGlobalAuthentication")]
        public virtual void ResetTargetsWithGlobalAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithNetworkEncryption")]
        public virtual void ResetTargetsWithNetworkEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithPasswordAuthentication")]
        public virtual void ResetTargetsWithPasswordAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithPrivilegeAnalysis")]
        public virtual void ResetTargetsWithPrivilegeAnalysis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithTablespaceEncryption")]
        public virtual void ResetTargetsWithTablespaceEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithTraditionalAudit")]
        public virtual void ResetTargetsWithTraditionalAudit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetsWithUnifiedAudit")]
        public virtual void ResetTargetsWithUnifiedAudit()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeatures))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesFilterList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesFilterList>()!;
        }

        [JsiiProperty(name: "securityFeatureCollection", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionList SecurityFeatureCollection
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInSubtreeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CompartmentIdInSubtreeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithColumnEncryptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithColumnEncryptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithDatabaseVaultInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithDatabaseVaultInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithExternalAuthenticationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithExternalAuthenticationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithFineGrainedAuditInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithFineGrainedAuditInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithGlobalAuthenticationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithGlobalAuthenticationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithNetworkEncryptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithNetworkEncryptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithPasswordAuthenticationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithPasswordAuthenticationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithPrivilegeAnalysisInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithPrivilegeAnalysisInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithTablespaceEncryptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithTablespaceEncryptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithTraditionalAuditInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithTraditionalAuditInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsWithUnifiedAuditInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetsWithUnifiedAuditInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentIdInSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object CompartmentIdInSubtree
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithColumnEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithColumnEncryption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithDatabaseVault", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithDatabaseVault
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithExternalAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithExternalAuthentication
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithFineGrainedAudit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithFineGrainedAudit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithGlobalAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithGlobalAuthentication
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithNetworkEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithNetworkEncryption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithPasswordAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithPasswordAuthentication
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithPrivilegeAnalysis", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithPrivilegeAnalysis
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithTablespaceEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithTablespaceEncryption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithTraditionalAudit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithTraditionalAudit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetsWithUnifiedAudit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetsWithUnifiedAudit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
