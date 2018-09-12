The Apache 2 license (given in full in LICENSE.txt) applies to all code in this repository which is copyright
by JetBrains. The following sections of the repository contain third-party code, to which different licenses
may apply:

## Kotlin Compiler

The following modules contain third-party code and are incorporated into the Kotlin compiler and/or
the Kotlin IntelliJ IDEA plugin:

 - Path: compiler/backend/src/org/jetbrains/kotlin/codegen/inline/MaxStackFrameSizeAndLocalsCalculator.java
     - License: BSD (license/third_party/asm_license.txt)
     - Origin: Derived from ASM: a very small and fast Java bytecode manipulation framework, Copyright (c) 2000-2011 INRIA, France Telecom

 - Path: compiler/backend/src/org/jetbrains/kotlin/codegen/inline/MaxLocalsCalculator.java
     - License: BSD (license/third_party/asm_license.txt)
     - Origin: Derived from ASM: a very small and fast Java bytecode manipulation framework, Copyright (c) 2000-2011 INRIA, France Telecom

 - Path: compiler/backend/src/org/jetbrains/kotlin/codegen/optimization/common/MethodAnalyzer.kt
     - License: BSD (license/third_party/asm_license.txt)
     - Origin: Derived from ASM: a very small and fast Java bytecode manipulation framework, Copyright (c) 2000-2011 INRIA, France Telecom

 - Path: core/reflection.jvm/src/kotlin.reflect/jvm/internal/pcollections
     - License: MIT (license/third_party/pcollections_LICENSE.txt)
     - Origin: Derived from PCollections, A Persistent Java Collections Library (https://pcollections.org/)

 - Path: eval4j/src/org/jetbrains/eval4j/interpreterLoop.kt
     - License: BSD (license/third_party/asm_license.txt)
     - Origin: Derived from ASM: a very small and fast Java bytecode manipulation framework, Copyright (c) 2000-2011 INRIA, France Telecom

 - Path: compiler/backend/src/org/jetbrains/kotlin/codegen/optimization/common/OptimizationBasicInterpreter.java
     - License: BSD (license/third_party/asm_license.txt)
     - Origin: Derived from ASM: a very small and fast Java bytecode manipulation framework, Copyright (c) 2000-2011 INRIA, France Telecom

 - Path: js/js.ast
     - License: BSD (license/third_party/dart_LICENSE.txt)
     - Origin: Originally part of the Dart compiler, (c) 2011 the Dart Project Authors,

 - Path: js/js.inliner/src/org/jetbrains/kotlin/js/inline/FunctionInlineMutator.kt
     - License: BSD (license/third_party/dart_LICENSE.txt)
     - Origin: Originally part of the Dart compiler, (c) 2011 the Dart Project Authors,

 - Path: js/js.parser/src/com/google
      - License: Netscape Public License 1.1 (license/third_party/rhino_LICENSE.txt)
      - Origin: Originally part of GWT, (C) 2007-08 Google Inc., distributed under the Apache 2 license. The code
        is derived from Rhino, (C) 1997-1999 Netscape Communications Corporation, distributed under the
        Netscape Public License.

 - Path: js/js.translator/qunit/qunit.js
      - License: MIT (license/third_party/qunit_license.txt)
      - Origin: QUnit, Copyright (c) 2012 John Resig, Jörn Zaefferer,

 - Path: libraries/stdlib/src/kotlin/collections
      - License: Apache 2 (license/third_party/gwt_license.txt)
      - Origin: Derived from GWT, (C) 2007-08 Google Inc.

 - Path: libraries/stdlib/jvm/src/kotlin/util/MathJVM.kt
      - License: Boost Software License 1.0 (license/third_party/boost_LICENSE.txt)
      - Origin: Derived from boost special math functions, Copyright Eric Ford & Hubert Holin 2001.

 - Path: libraries/stdlib/js/src/kotlin/collections
      - License: Apache 2 (license/third_party/gwt_license.txt)
      - Origin: Derived from GWT, (C) 2007-08 Google Inc.

 - Path: libraries/stdlib/js/src/js/long.js
      - License: Apache 2 (license/third_party/closure-compiler_LICENSE.txt)
      - Origin: Google Closure Library, Copyright 2009 The Closure Library Authors

 - Path: libraries/stdlib/js/src/js/polyfills.js
      - License: Boost Software License 1.0 (license/third_party/boost_LICENSE.txt)
      - Origin: Derived from boost special math functions, Copyright Eric Ford & Hubert Holin 2001.

 - Path: plugins/lint/android-annotations
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: plugins/lint/lint-api
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: plugins/lint/lint-checks
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: plugins/lint/lint-idea
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

## Kotlin Test Data

The following source code is used for testing the Kotlin compiler and/or plugin and is not incorporated into
any distributions of the compiler, libraries or plugin:

 - Path: third-party/annotations/android
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: third-party/annotations/com/android
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: third-party/annotations/org/eclipse
      - License: Eclipse Public License v1.0 (license/third_party/testdata/eclipse_license.txt)
      - Origin: Eclipse JDT, Copyright (c) 2011, 2013 Stephan Herrmann and others.

 - Path: third-party/annotations/androidx
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: third-party/annotations/edu/umd/cs/findbugs
      - License: LGPL 2.1 (license/third_party/testdata/findbugs_license.txt)
      - Origin: Bytecode Analysis Framework, Copyright (C) 2005 University of Maryland

 - Path: third-party/jdk8-annotations/org/eclipse
      - License: Eclipse Public License v1.0 (license/third_party/testdata/eclipse_license.txt)
      - Origin: Eclipse JDT, Copyright (c) 2011, 2013 Stephan Herrmann and others.

 - Path: third-party/annotations/io/reactivex
      - License: Apache 2 (license/third_party/testdata/rxjava_license.txt)
      - Origin: RxJava, Copyright (c) 2016-present, RxJava Contributors

 - Path: third-party/annotations/lombok
      - License: MIT (license/third_party/testdata/lombok_license.txt)
      - Origin: Project Lombok, Copyright (C) 2009-2013 The Project Lombok Authors

 - Path: idea/idea-android/tests/org/jetbrains/kotlin/android/AndroidTestBase.java
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: idea/testData/android/lintQuickfix/requiresApi/RequiresApi.java
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: idea/testData/android/lint/IntRange.java
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: idea/testData/android/lint/RequiresPermission.java
      - License: Apache 2 (license/third_party/aosp_license.txt)
      - Origin: Copyright (C) 2011-15 The Android Open Source Project

 - Path: libraries/tools/kotlin-gradle-plugin-integration-tests/src/test/resources/testProject/allOpenSpring/src/org/springframework/stereotype/Component.java
      - License: Apache 2 (license/third_party/testdata/spring_license.txt)
      - Origin: Spring Framework, Copyright 2002-2007 the original author or authors.

 - Path: libraries/tools/kotlin-gradle-plugin-integration-tests/src/test/resources/testProject/AndroidDaggerProject
      - License: Apache 2 (license/third_party/testdata/dagger_license.txt)
      - Origin: Dagger, Copyright (C) 2013 Square, Inc.

 - Path: libraries/tools/kotlin-gradle-plugin-integration-tests/src/test/resources/testProject/kapt2
      - License: Apache 2 (license/third_party/testdata/dagger_license.txt)
      - Origin: Dagger, Copyright (C) 2013 Square, Inc.

 - Path: libraries/tools/kotlin-maven-plugin-test/src/it/test-allopen-spring/src/main/java/org/springframework/stereotype/Component.java
      - License: Apache 2 (license/third_party/testdata/spring_license.txt)
      - Origin: Spring Framework, Copyright 2002-2007 the original author or authors.

## Kotlin Tools and Libraries Tests

The following source code is used for testing the Kotlin tools and/or libraries and is not incorporated into
any distributions of the tools or libraries:

 - Path: libraries/tools/kotlin-gradle-plugin-integration-tests/src/test/kotlin/org/jetbrains/kotlin/gradle/PluginsDslIT.kt
      - License: Apache 2 (license/third_party/testdata/gradle_license.txt)
      - Origin: Gradle, Copyright 2002-2017 Gradle, Inc.

 - Path: libraries/tools/kotlin-gradle-plugin-integration-tests/target/test-classes/testProject/noArgJpa/src/javax/persistence/Entity.java
      - License: Eclipse Public License v1.0 (license/third_party/testdata/eclipse_license.txt)
             and Eclipse Distribution License - v1.0 (license/third_party/testdata/eclipse_distribution_license.txt)
      - Origin: javax.persistence, Copyright (c) 2008, 2017 Sun Microsystems, Oracle Corporation.

 - Path: libraries/tools/kotlin-gradle-plugin-integration-tests/src/test/resources/testProject/noArgJpa/src/javax/persistence/Entity.java
      - License: Eclipse Public License v1.0 (license/third_party/testdata/eclipse_license.txt)
             and Eclipse Distribution License - v1.0 (license/third_party/testdata/eclipse_distribution_license.txt)
      - Origin: javax.persistence, Copyright (c) 2008, 2017 Sun Microsystems, Oracle Corporation.

 - Path: libraries/tools/kotlin-gradle-plugin-integration-tests/src/test/resources/testProject/noArgJpa/src/javax/persistence/Embeddable.java
      - License: Eclipse Public License v1.0 (license/third_party/testdata/eclipse_license.txt)
             and Eclipse Distribution License - v1.0 (license/third_party/testdata/eclipse_distribution_license.txt)
      - Origin: javax.persistence, Copyright (c) 2008, 2017 Sun Microsystems, Oracle Corporation.

## Example Code

The following code is provided as examples and is not incorporated into
any distributions of the compiler, libraries or plugin:

 - Path: libraries/examples/browser-example/src/js/jquery.js
      - License: MIT (license/third_party/jquery_license.txt)
      - Origin: jQuery JavaScript Library v1.6.2, Copyright 2011, John Resig

 - Path: libraries/examples/browser-example-with-library/src/js/jquery.js
      - License: MIT (license/third_party/jquery_license.txt)
      - Origin: jQuery JavaScript Library v1.6.2, Copyright 2011, John Resig