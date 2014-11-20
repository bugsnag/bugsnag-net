// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.


// Ignore these rules in Payload namespace as these are used to directely serialise data into JSON
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Bugsnag.Core.Payload.EventInfo.#Exceptions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Bugsnag.Core.Payload.EventInfo.#Threads")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Bugsnag.Core.Payload.ExceptionInfo.#StackTrace")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Bugsnag.Core.Payload.Notification.#Events")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Bugsnag.Core.Payload.ThreadInfo.#StackTrace")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Bugsnag.Core.Payload.EventInfo.#Exceptions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Bugsnag.Core.Payload.EventInfo.#Threads")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Bugsnag.Core.Payload.EventInfo.#Metadata")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Bugsnag.Core.Payload.ExceptionInfo.#StackTrace")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Bugsnag.Core.Payload.Notification.#Events")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Bugsnag.Core.Payload.ThreadInfo.#StackTrace")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Bugsnag.Core.Payload.EventInfo.#PayloadVersion")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Bugsnag.Core.Payload.NotifierInfo.#Url")]

// We use Configuration, Event and Metadata due to them being common terms used in other Bugsnag libraries
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Bugsnag.Core.Configuration")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Event", Scope = "type", Target = "Bugsnag.Core.Event")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Bugsnag.Core.Metadata")]

// The metadata is stored optimally in a nested generic type and is ideal for serialisation to JSON 
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Bugsnag.Core.Payload.EventInfo.#Metadata")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Bugsnag.Core.Metadata.#MetadataStore")]
