using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics oci_data_safe_user_assessment_password_expiry_date_analytics}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics), fullyQualifiedName: "oci.dataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsConfig\"}}]")]
    public class DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics oci_data_safe_user_assessment_password_expiry_date_analytics} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics(Constructs.Construct scope, string id, oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetTimePasswordExpiryLessThan")]
        public virtual void ResetTimePasswordExpiryLessThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserCategory")]
        public virtual void ResetUserCategory()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilterList\"}")]
        public virtual oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilterList>()!;
        }

        [JsiiProperty(name: "userAggregations", typeJson: "{\"fqn\":\"oci.dataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsUserAggregationsList\"}")]
        public virtual oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsUserAggregationsList UserAggregations
        {
            get => GetInstanceProperty<oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsUserAggregationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessLevelInput
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
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "timePasswordExpiryLessThanInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimePasswordExpiryLessThanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAssessmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserAssessmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userCategoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserCategoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessLevel
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

        [JsiiProperty(name: "timePasswordExpiryLessThan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePasswordExpiryLessThan
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserAssessmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserCategory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
