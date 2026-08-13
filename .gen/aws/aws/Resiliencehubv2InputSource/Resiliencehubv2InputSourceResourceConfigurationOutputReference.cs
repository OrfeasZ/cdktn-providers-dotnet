using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    [JsiiClass(nativeType: typeof(aws.Resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationOutputReference), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Resiliencehubv2InputSourceResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Resiliencehubv2InputSourceResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Resiliencehubv2InputSourceResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Resiliencehubv2InputSourceResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks" />)[]</param>
        [JsiiMethod(name: "putEks", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEks(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag" />)[]</param>
        [JsiiMethod(name: "putResourceTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCfnStackArn")]
        public virtual void ResetCfnStackArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesignFileS3Url")]
        public virtual void ResetDesignFileS3Url()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEks")]
        public virtual void ResetEks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTag")]
        public virtual void ResetResourceTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTfStateFileUrl")]
        public virtual void ResetTfStateFileUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "eks", typeJson: "{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksList\"}")]
        public virtual aws.Resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksList Eks
        {
            get => GetInstanceProperty<aws.Resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksList>()!;
        }

        [JsiiProperty(name: "resourceTag", typeJson: "{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTagList\"}")]
        public virtual aws.Resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTagList ResourceTag
        {
            get => GetInstanceProperty<aws.Resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTagList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cfnStackArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CfnStackArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "designFileS3UrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DesignFileS3UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EksInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceTagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tfStateFileUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TfStateFileUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cfnStackArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CfnStackArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "designFileS3Url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesignFileS3Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tfStateFileUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfStateFileUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfiguration" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfiguration\"}]}}", isOptional: true)]
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
                        case aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfiguration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfiguration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
