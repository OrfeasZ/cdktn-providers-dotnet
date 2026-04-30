using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index aws_dynamodb_global_secondary_index}.</summary>
    [JsiiClass(nativeType: typeof(aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndex), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndex", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexConfig\"}}]")]
    public class DynamodbGlobalSecondaryIndex : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index aws_dynamodb_global_secondary_index} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DynamodbGlobalSecondaryIndex(Constructs.Construct scope, string id, aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbGlobalSecondaryIndex(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbGlobalSecondaryIndex(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DynamodbGlobalSecondaryIndex resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DynamodbGlobalSecondaryIndex to import.</param>
        /// <param name="importFromId">The id of the existing DynamodbGlobalSecondaryIndex that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DynamodbGlobalSecondaryIndex to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DynamodbGlobalSecondaryIndex to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DynamodbGlobalSecondaryIndex that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DynamodbGlobalSecondaryIndex to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndex), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putKeySchema", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchema\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKeySchema(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexKeySchema[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexKeySchema).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexKeySchema).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnDemandThroughput", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughput\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOnDemandThroughput(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexOnDemandThroughput[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexOnDemandThroughput).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexOnDemandThroughput).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProjection", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProjection\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProjection(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProjection[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProjection).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProjection).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProvisionedThroughput", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughput\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProvisionedThroughput(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProvisionedThroughput[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProvisionedThroughput).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProvisionedThroughput).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWarmThroughput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughput\"}}]")]
        public virtual void PutWarmThroughput(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexWarmThroughput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexWarmThroughput)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKeySchema")]
        public virtual void ResetKeySchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemandThroughput")]
        public virtual void ResetOnDemandThroughput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjection")]
        public virtual void ResetProjection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisionedThroughput")]
        public virtual void ResetProvisionedThroughput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarmThroughput")]
        public virtual void ResetWarmThroughput()
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
        = GetStaticProperty<string>(typeof(aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndex))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keySchema", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchemaList\"}")]
        public virtual aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchemaList KeySchema
        {
            get => GetInstanceProperty<aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchemaList>()!;
        }

        [JsiiProperty(name: "onDemandThroughput", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughputList\"}")]
        public virtual aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughputList OnDemandThroughput
        {
            get => GetInstanceProperty<aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughputList>()!;
        }

        [JsiiProperty(name: "projection", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProjectionList\"}")]
        public virtual aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProjectionList Projection
        {
            get => GetInstanceProperty<aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProjectionList>()!;
        }

        [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughputList\"}")]
        public virtual aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughputList ProvisionedThroughput
        {
            get => GetInstanceProperty<aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughputList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexTimeoutsOutputReference\"}")]
        public virtual aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "warmThroughput", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughputOutputReference\"}")]
        public virtual aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughputOutputReference WarmThroughput
        {
            get => GetInstanceProperty<aws.DynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughputOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndexNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keySchemaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KeySchemaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandThroughputInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OnDemandThroughputInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProjection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProjectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisionedThroughputInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProvisionedThroughputInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmThroughputInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughput\"}]}}", isOptional: true)]
        public virtual object? WarmThroughputInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
