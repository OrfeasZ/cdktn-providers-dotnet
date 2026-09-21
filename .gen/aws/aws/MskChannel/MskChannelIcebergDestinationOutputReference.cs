using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiClass(nativeType: typeof(aws.MskChannel.MskChannelIcebergDestinationOutputReference), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MskChannelIcebergDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MskChannelIcebergDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MskChannelIcebergDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskChannelIcebergDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationCatalog" />)[]</param>
        [JsiiMethod(name: "putCatalog", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationCatalog\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCatalog(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.MskChannel.IMskChannelIcebergDestinationCatalog[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationCatalog).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationCatalog).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationDeadLetterQueueS3" />)[]</param>
        [JsiiMethod(name: "putDeadLetterQueueS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDeadLetterQueueS3\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDeadLetterQueueS3(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.MskChannel.IMskChannelIcebergDestinationDeadLetterQueueS3[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationDeadLetterQueueS3).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationDeadLetterQueueS3).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationDestinationTable" />)[]</param>
        [JsiiMethod(name: "putDestinationTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDestinationTable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDestinationTable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.MskChannel.IMskChannelIcebergDestinationDestinationTable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationDestinationTable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationDestinationTable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationSchemaEvolution" />)[]</param>
        [JsiiMethod(name: "putSchemaEvolution", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationSchemaEvolution\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSchemaEvolution(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.MskChannel.IMskChannelIcebergDestinationSchemaEvolution[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationSchemaEvolution).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationSchemaEvolution).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationTableCreation" />)[]</param>
        [JsiiMethod(name: "putTableCreation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationTableCreation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTableCreation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.MskChannel.IMskChannelIcebergDestinationTableCreation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationTableCreation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationTableCreation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalog")]
        public virtual void ResetCatalog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompressionType")]
        public virtual void ResetCompressionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataFreshnessInSeconds")]
        public virtual void ResetDataFreshnessInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeadLetterQueueS3")]
        public virtual void ResetDeadLetterQueueS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationTable")]
        public virtual void ResetDestinationTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaEvolution")]
        public virtual void ResetSchemaEvolution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableCreation")]
        public virtual void ResetTableCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "catalog", typeJson: "{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationCatalogList\"}")]
        public virtual aws.MskChannel.MskChannelIcebergDestinationCatalogList Catalog
        {
            get => GetInstanceProperty<aws.MskChannel.MskChannelIcebergDestinationCatalogList>()!;
        }

        [JsiiProperty(name: "deadLetterQueueS3", typeJson: "{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDeadLetterQueueS3List\"}")]
        public virtual aws.MskChannel.MskChannelIcebergDestinationDeadLetterQueueS3List DeadLetterQueueS3
        {
            get => GetInstanceProperty<aws.MskChannel.MskChannelIcebergDestinationDeadLetterQueueS3List>()!;
        }

        [JsiiProperty(name: "destinationTable", typeJson: "{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDestinationTableList\"}")]
        public virtual aws.MskChannel.MskChannelIcebergDestinationDestinationTableList DestinationTable
        {
            get => GetInstanceProperty<aws.MskChannel.MskChannelIcebergDestinationDestinationTableList>()!;
        }

        [JsiiProperty(name: "schemaEvolution", typeJson: "{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationSchemaEvolutionList\"}")]
        public virtual aws.MskChannel.MskChannelIcebergDestinationSchemaEvolutionList SchemaEvolution
        {
            get => GetInstanceProperty<aws.MskChannel.MskChannelIcebergDestinationSchemaEvolutionList>()!;
        }

        [JsiiProperty(name: "tableCreation", typeJson: "{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationTableCreationList\"}")]
        public virtual aws.MskChannel.MskChannelIcebergDestinationTableCreationList TableCreation
        {
            get => GetInstanceProperty<aws.MskChannel.MskChannelIcebergDestinationTableCreationList>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appendOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AppendOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationCatalog" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "catalogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationCatalog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CatalogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompressionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataFreshnessInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataFreshnessInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationDeadLetterQueueS3" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deadLetterQueueS3Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDeadLetterQueueS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DeadLetterQueueS3Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationDestinationTable" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationTableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDestinationTable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DestinationTableInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationSchemaEvolution" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemaEvolutionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationSchemaEvolution\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SchemaEvolutionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceExecutionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationTableCreation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tableCreationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationTableCreation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TableCreationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "appendOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AppendOnly
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

        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompressionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataFreshnessInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataFreshnessInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.MskChannel.IMskChannelIcebergDestination" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestination\"}]}}", isOptional: true)]
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
                        case aws.MskChannel.IMskChannelIcebergDestination cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestination).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
