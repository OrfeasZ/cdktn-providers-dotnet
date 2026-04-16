using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceTemplate
{
    [JsiiClass(nativeType: typeof(scaleway.AutoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesOutputReference), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingInstanceTemplateVolumesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AutoscalingInstanceTemplateVolumesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AutoscalingInstanceTemplateVolumesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingInstanceTemplateVolumesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFromEmpty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmpty\"}}]")]
        public virtual void PutFromEmpty(scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFromSnapshot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshot\"}}]")]
        public virtual void PutFromSnapshot(scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBoot")]
        public virtual void ResetBoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFromEmpty")]
        public virtual void ResetFromEmpty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFromSnapshot")]
        public virtual void ResetFromSnapshot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerfIops")]
        public virtual void ResetPerfIops()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fromEmpty", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmptyOutputReference\"}")]
        public virtual scaleway.AutoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmptyOutputReference FromEmpty
        {
            get => GetInstanceProperty<scaleway.AutoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmptyOutputReference>()!;
        }

        [JsiiProperty(name: "fromSnapshot", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshotOutputReference\"}")]
        public virtual scaleway.AutoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshotOutputReference FromSnapshot
        {
            get => GetInstanceProperty<scaleway.AutoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshotOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BootInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromEmptyInput", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmpty\"}", isOptional: true)]
        public virtual scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty? FromEmptyInput
        {
            get => GetInstanceProperty<scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromSnapshotInput", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshot\"}", isOptional: true)]
        public virtual scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot? FromSnapshotInput
        {
            get => GetInstanceProperty<scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perfIopsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PerfIopsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "boot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Boot
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "perfIops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PerfIops
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumes\"}]}}", isOptional: true)]
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
                        case scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumes cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumes).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
