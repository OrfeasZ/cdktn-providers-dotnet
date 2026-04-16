using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecFunctionOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecFunctionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecFunctionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecFunctionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppSpecFunctionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecFunctionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAlert", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionAlert\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAlert(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecFunctionAlert[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionAlert).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionAlert).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBitbucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionBitbucket\"}}]")]
        public virtual void PutBitbucket(digitalocean.App.IAppSpecFunctionBitbucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionBitbucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCors", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionCors\"}}]")]
        public virtual void PutCors(digitalocean.App.IAppSpecFunctionCors @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionCors)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnv", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionEnv\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnv(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecFunctionEnv[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionEnv).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionEnv).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionGit\"}}]")]
        public virtual void PutGit(digitalocean.App.IAppSpecFunctionGit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionGit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionGithub\"}}]")]
        public virtual void PutGithub(digitalocean.App.IAppSpecFunctionGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitlab", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionGitlab\"}}]")]
        public virtual void PutGitlab(digitalocean.App.IAppSpecFunctionGitlab @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionGitlab)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestination\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogDestination(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecFunctionLogDestination[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionLogDestination).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionLogDestination).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionRoutes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoutes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecFunctionRoutes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionRoutes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionRoutes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlert")]
        public virtual void ResetAlert()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitbucket")]
        public virtual void ResetBitbucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCors")]
        public virtual void ResetCors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnv")]
        public virtual void ResetEnv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGit")]
        public virtual void ResetGit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithub")]
        public virtual void ResetGithub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitlab")]
        public virtual void ResetGitlab()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogDestination")]
        public virtual void ResetLogDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutes")]
        public virtual void ResetRoutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDir")]
        public virtual void ResetSourceDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "alert", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionAlertList\"}")]
        public virtual digitalocean.App.AppSpecFunctionAlertList Alert
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionAlertList>()!;
        }

        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionBitbucketOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionBitbucketOutputReference Bitbucket
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionBitbucketOutputReference>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionCorsOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionCorsOutputReference Cors
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionCorsOutputReference>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionEnvList\"}")]
        public virtual digitalocean.App.AppSpecFunctionEnvList Env
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionEnvList>()!;
        }

        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGitOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionGitOutputReference Git
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionGitOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGithubOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionGithubOutputReference Github
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionGithubOutputReference>()!;
        }

        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGitlabOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionGitlabOutputReference Gitlab
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionGitlabOutputReference>()!;
        }

        [JsiiProperty(name: "logDestination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationList\"}")]
        public virtual digitalocean.App.AppSpecFunctionLogDestinationList LogDestination
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionLogDestinationList>()!;
        }

        [JsiiProperty(name: "routes", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionRoutesList\"}")]
        public virtual digitalocean.App.AppSpecFunctionRoutesList Routes
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionRoutesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AlertInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitbucketInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionBitbucket\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionBitbucket? BitbucketInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionBitbucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionCors\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionCors? CorsInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionCors?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "envInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGithub\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionGithub? GithubInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGit\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionGit? GitInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionGit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitlabInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGitlab\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionGitlab? GitlabInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionGitlab?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDestinationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogDestinationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RoutesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDirInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceDirInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDir
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecFunction\"}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecFunction cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunction).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
