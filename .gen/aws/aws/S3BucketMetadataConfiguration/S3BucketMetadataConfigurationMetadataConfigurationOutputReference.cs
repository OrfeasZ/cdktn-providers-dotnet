using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationOutputReference), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketMetadataConfigurationMetadataConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public S3BucketMetadataConfigurationMetadataConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected S3BucketMetadataConfigurationMetadataConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketMetadataConfigurationMetadataConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInventoryTableConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInventoryTableConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJournalTableConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJournalTableConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInventoryTableConfiguration")]
        public virtual void ResetInventoryTableConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJournalTableConfiguration")]
        public virtual void ResetJournalTableConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationDestinationList\"}")]
        public virtual aws.S3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationDestinationList Destination
        {
            get => GetInstanceProperty<aws.S3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationDestinationList>()!;
        }

        [JsiiProperty(name: "inventoryTableConfiguration", typeJson: "{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationList\"}")]
        public virtual aws.S3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationList InventoryTableConfiguration
        {
            get => GetInstanceProperty<aws.S3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationList>()!;
        }

        [JsiiProperty(name: "journalTableConfiguration", typeJson: "{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationList\"}")]
        public virtual aws.S3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationList JournalTableConfiguration
        {
            get => GetInstanceProperty<aws.S3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inventoryTableConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InventoryTableConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "journalTableConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationJournalTableConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JournalTableConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfiguration\"}]}}", isOptional: true)]
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
                        case aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfiguration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfiguration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
