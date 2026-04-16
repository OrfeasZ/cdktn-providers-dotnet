using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessCollectionGroup
{
    [JsiiClass(nativeType: typeof(aws.OpensearchserverlessCollectionGroup.OpensearchserverlessCollectionGroupCapacityLimitsOutputReference), fullyQualifiedName: "aws.opensearchserverlessCollectionGroup.OpensearchserverlessCollectionGroupCapacityLimitsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class OpensearchserverlessCollectionGroupCapacityLimitsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public OpensearchserverlessCollectionGroupCapacityLimitsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchserverlessCollectionGroupCapacityLimitsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchserverlessCollectionGroupCapacityLimitsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxIndexingCapacityInOcu")]
        public virtual void ResetMaxIndexingCapacityInOcu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxSearchCapacityInOcu")]
        public virtual void ResetMaxSearchCapacityInOcu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinIndexingCapacityInOcu")]
        public virtual void ResetMinIndexingCapacityInOcu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinSearchCapacityInOcu")]
        public virtual void ResetMinSearchCapacityInOcu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxIndexingCapacityInOcuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxIndexingCapacityInOcuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSearchCapacityInOcuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSearchCapacityInOcuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minIndexingCapacityInOcuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinIndexingCapacityInOcuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minSearchCapacityInOcuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinSearchCapacityInOcuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxIndexingCapacityInOcu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxIndexingCapacityInOcu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSearchCapacityInOcu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSearchCapacityInOcu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minIndexingCapacityInOcu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinIndexingCapacityInOcu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minSearchCapacityInOcu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSearchCapacityInOcu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.opensearchserverlessCollectionGroup.OpensearchserverlessCollectionGroupCapacityLimits\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OpensearchserverlessCollectionGroup.IOpensearchserverlessCollectionGroupCapacityLimits cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OpensearchserverlessCollectionGroup.IOpensearchserverlessCollectionGroupCapacityLimits).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
