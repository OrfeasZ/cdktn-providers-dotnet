using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationCustomTable
{
    [JsiiClass(nativeType: typeof(oci.MeteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableOutputReference), fullyQualifiedName: "oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MeteringComputationCustomTableSavedCustomTableOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MeteringComputationCustomTableSavedCustomTableOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationCustomTableSavedCustomTableOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationCustomTableSavedCustomTableOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGroupByTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableGroupByTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGroupByTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MeteringComputationCustomTable.IMeteringComputationCustomTableSavedCustomTableGroupByTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationCustomTable.IMeteringComputationCustomTableSavedCustomTableGroupByTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationCustomTable.IMeteringComputationCustomTableSavedCustomTableGroupByTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetColumnGroupBy")]
        public virtual void ResetColumnGroupBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentDepth")]
        public virtual void ResetCompartmentDepth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupByTag")]
        public virtual void ResetGroupByTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRowGroupBy")]
        public virtual void ResetRowGroupBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "groupByTag", typeJson: "{\"fqn\":\"oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableGroupByTagList\"}")]
        public virtual oci.MeteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableGroupByTagList GroupByTag
        {
            get => GetInstanceProperty<oci.MeteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableGroupByTagList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnGroupByInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ColumnGroupByInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentDepthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CompartmentDepthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupByTagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GroupByTagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rowGroupByInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RowGroupByInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "columnGroupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ColumnGroupBy
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompartmentDepth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rowGroupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RowGroupBy
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTable\"}", isOptional: true)]
        public virtual oci.MeteringComputationCustomTable.IMeteringComputationCustomTableSavedCustomTable? InternalValue
        {
            get => GetInstanceProperty<oci.MeteringComputationCustomTable.IMeteringComputationCustomTableSavedCustomTable?>();
            set => SetInstanceProperty(value);
        }
    }
}
